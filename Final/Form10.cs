using System;
using System.IO;
using System.Windows.Forms;

namespace Final
{
    public partial class Form10 : Form
    {
        private string inputText1;
        private int index;

        public Form10(string text1, int recordIndex)
        {
            InitializeComponent();
            inputText1 = text1;
            index = recordIndex;
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            label1.Text = $"{inputText1}";
            string filePath = Path.Combine(Application.StartupPath, "output.txt");
            LoadFileData(filePath);
            
        }

        public void LoadFileData(string filePath)
        {
            
            try
            {
                string[] fileLines = File.ReadAllLines(filePath);
                for (int i = 0; i < fileLines.Length; i++)
                {
                    if (fileLines[i] == "-" && i + 1 < fileLines.Length && fileLines[i + 1] == inputText1)
                    {
                        if (i + 2 < fileLines.Length)
                        {
                            label2.Text = fileLines[i + 2].Trim();
                        }

                        if (i + 3 < fileLines.Length)
                        {
                            label3.Text = fileLines[i + 3].Trim();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при читанні файлу: " + ex.Message);
            }
        }
    }
}
