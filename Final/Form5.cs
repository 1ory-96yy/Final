using System;
using System.IO;
using System.Windows.Forms;

namespace Final
{
    public partial class Form5 : Form
    {
        private Form1 form1;

        public Form5(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string filePath = Path.Combine(Application.StartupPath, "output.txt");

            if (File.Exists(filePath))
            {
                string[] existingLines = File.ReadAllLines(filePath);

                for (int i = 0; i < existingLines.Length; i++)
                {
                    if (existingLines[i] == "-" && i + 1 < existingLines.Length && existingLines[i + 1] == username)
                    {
                        MessageBox.Show("Користувач з таким ім'ям вже існує.");
                        return;
                    }
                }
            }

            string textToWrite = $"-{Environment.NewLine}{username}{Environment.NewLine}{password}{Environment.NewLine}";

            try
            {
                File.AppendAllText(filePath, textToWrite);
                MessageBox.Show("Реєстрація успішна.");
                form1.ReceiveData(username, (File.ReadAllLines(filePath).Length - 3) / 3);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при записі в файл: " + ex.Message);
            }
        }
    }
}
