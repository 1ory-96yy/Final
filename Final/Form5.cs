using System;
using System.IO;
using System.Windows.Forms;

namespace Final
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textBox1Text = textBox1.Text;

            string filePath = Path.Combine(Application.StartupPath, "output.txt");

            int currentIndex = 1;

            if (File.Exists(filePath))
            {
                string[] existingLines = File.ReadAllLines(filePath);

                foreach (string line in existingLines)
                {
                    if (line.Contains(textBox1Text)) 
                    {
                        MessageBox.Show("Такий текст вже є в списку.");
                        return;
                    }
                }

                currentIndex = existingLines.Length + 1;
            }
            string textToWrite = $"{currentIndex}. {textBox1Text}{Environment.NewLine}";

            try
            {
                File.AppendAllText(filePath, textToWrite);
                MessageBox.Show("Текст успішно записано в файл.");

                Form1 form1 = new Form1();
                form1.ReceiveData(textBox1Text, currentIndex);
                form1.Show();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при записі в файл: " + ex.Message);
            }
        }
    }
}
