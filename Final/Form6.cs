using System;
using System.IO;
using System.Windows.Forms;

namespace Final
{
    public partial class Form6 : Form
    {
        private List<string> listItems = new List<string>();
        public Form6()
        {
            InitializeComponent();
        }
        public void AddItemToListBox(string itemName, int itemCount)
        {
            string listItem = $"{itemName} - {itemCount}";
            listItems.Add(listItem);
            listBox1.Items.Add(listItem);
        }

        private void SaveListBoxData()
        {
            string filePath = Path.Combine(Application.StartupPath, "data.txt");

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
            string filePath = Path.Combine(Application.StartupPath, "data.txt");

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

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveListBoxData();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            LoadListBoxData();
        }
        


    }
}
