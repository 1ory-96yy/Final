using System;
using System.Windows.Forms;

namespace Final
{
    public partial class Form2 : Form
    {
        private Form7 form7;
        private Form6 form6;
        public Form2(System.Drawing.Image image, string labelText, Form7 form7Instance, Form6 form6Instance)
        {
            InitializeComponent();
            pictureBox1.Image = image;
            label1.Text = labelText;
            form7 = form7Instance;
            form6 = form6Instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string itemName = label1.Text;
            int itemCount = (int)numericUpDown1.Value;

            form7.AddItemToListBox(itemName, itemCount);
        }
        private void button2_Click(object sender, EventArgs e)
        {

            string itemName = label1.Text;
            int itemCount = 1;

            form6.AddItemToListBox(itemName, itemCount);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
