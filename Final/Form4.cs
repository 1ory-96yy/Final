using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Final
{
    public partial class Form4 : Form
    {
        private Form1 form1;

        public Form4(Form1 form1)
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
                        if (i + 2 < existingLines.Length && existingLines[i + 2] == password)
                        {
                            MessageBox.Show("Вхід успішний.");
                            form1.ReceiveData(username, i / 3);
                            this.Close();
                            return;
                        }
                    }
                }

                MessageBox.Show("Неправильне ім'я користувача або пароль.");
            }
            else
            {
                MessageBox.Show("Файл користувачів не знайдено.");
            }
        }
    }
}
