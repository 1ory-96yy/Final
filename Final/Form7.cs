using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Final
{
    public partial class Form7 : Form
    {
        private List<string> listItems = new List<string>();

        public Form7()
        {
            InitializeComponent();
        }

        public void AddItemToListBox(string itemName, int itemCount)
        {
            string listItem = $"{itemName} - {itemCount}";
            listItems.Add(listItem);
            listBox1.Items.Add(listItem);
            SaveListBoxData();
        }

        private void SaveListBoxData()
        {
            string filePath = Path.Combine(Application.StartupPath, "listbox_data.txt");

            try
            {
                File.WriteAllLines(filePath, listItems);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при збереженні даних: " + ex.Message);
            }
        }

        private void LoadListBoxData()
        {
            string filePath = Path.Combine(Application.StartupPath, "listbox_data.txt");

            if (File.Exists(filePath))
            {
                try
                {
                    var listBoxData = File.ReadAllLines(filePath);
                    listItems.AddRange(listBoxData);

                    foreach (var item in listBoxData)
                    {
                        listBox1.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при завантаженні даних: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Файл не знайдено: " + filePath);
            }
        }
        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveListBoxData();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            LoadListBoxData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Будь ласка, додайте якісь товари до корзини.");
            }
            else
            {
                Form9 form9 = new Form9();
                form9.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedItem = listBox1.SelectedItem.ToString();

                listItems.Remove(selectedItem);

                listBox1.Items.Remove(selectedItem);

                SaveListBoxData();
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть елемент для видалення.");
            }
        }

        
    }
}
