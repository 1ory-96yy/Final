using System;
using System.Drawing;
using System.Windows.Forms;

namespace Final
{
    public partial class Form1 : Form
    {
        public Color BackgroundColor { get; set; }
        public int TextSize { get; set; }
        public Color TextColor { get; set; }

        private Image[] images = new Image[24];
        private string[] labels = new string[24];

        private Form7 form7;
        private Form6 form6;
        private bool isSignedIn = false;

        private string receivedText;
        private int receivedIndex;

        public Form1()
        {
            InitializeComponent();
            images[0] = pictureBox1.Image;
            images[1] = pictureBox2.Image;
            images[2] = pictureBox3.Image;
            images[3] = pictureBox4.Image;
            images[4] = pictureBox5.Image;
            images[5] = pictureBox6.Image;
            images[6] = pictureBox7.Image;
            images[7] = pictureBox8.Image;
            images[8] = pictureBox9.Image;
            images[9] = pictureBox10.Image;
            images[10] = pictureBox11.Image;
            images[11] = pictureBox12.Image;
            images[12] = pictureBox13.Image;
            images[13] = pictureBox14.Image;
            images[14] = pictureBox15.Image;
            images[15] = pictureBox16.Image;
            images[16] = pictureBox17.Image;
            images[17] = pictureBox18.Image;
            images[18] = pictureBox19.Image;
            images[19] = pictureBox20.Image;
            images[20] = pictureBox21.Image;
            images[21] = pictureBox22.Image;
            images[22] = pictureBox23.Image;
            images[23] = pictureBox24.Image;

            labels[0] = label1.Text;
            labels[1] = label2.Text;
            labels[2] = label3.Text;
            labels[3] = label4.Text;
            labels[4] = label5.Text;
            labels[5] = label6.Text;
            labels[6] = label7.Text;
            labels[7] = label8.Text;
            labels[8] = label9.Text;
            labels[9] = label10.Text;
            labels[10] = label11.Text;
            labels[11] = label12.Text;
            labels[12] = label13.Text;
            labels[13] = label14.Text;
            labels[14] = label15.Text;
            labels[15] = label16.Text;
            labels[16] = label17.Text;
            labels[17] = label18.Text;
            labels[18] = label19.Text;
            labels[19] = label20.Text;
            labels[20] = label21.Text;
            labels[21] = label22.Text;
            labels[22] = label23.Text;
            labels[23] = label24.Text;

            pictureBox1.Click += (sender, e) => OpenForm2(0);
            pictureBox2.Click += (sender, e) => OpenForm2(1);
            pictureBox3.Click += (sender, e) => OpenForm2(2);
            pictureBox4.Click += (sender, e) => OpenForm2(3);
            pictureBox5.Click += (sender, e) => OpenForm2(4);
            pictureBox6.Click += (sender, e) => OpenForm2(5);
            pictureBox7.Click += (sender, e) => OpenForm2(6);
            pictureBox8.Click += (sender, e) => OpenForm2(7);
            pictureBox9.Click += (sender, e) => OpenForm2(8);
            pictureBox10.Click += (sender, e) => OpenForm2(9);
            pictureBox11.Click += (sender, e) => OpenForm2(10);
            pictureBox12.Click += (sender, e) => OpenForm2(11);
            pictureBox13.Click += (sender, e) => OpenForm2(12);
            pictureBox14.Click += (sender, e) => OpenForm2(13);
            pictureBox15.Click += (sender, e) => OpenForm2(14);
            pictureBox16.Click += (sender, e) => OpenForm2(15);
            pictureBox17.Click += (sender, e) => OpenForm2(16);
            pictureBox18.Click += (sender, e) => OpenForm2(17);
            pictureBox19.Click += (sender, e) => OpenForm2(18);
            pictureBox20.Click += (sender, e) => OpenForm2(19);
            pictureBox21.Click += (sender, e) => OpenForm2(20);
            pictureBox22.Click += (sender, e) => OpenForm2(21);
            pictureBox23.Click += (sender, e) => OpenForm2(22);
            pictureBox24.Click += (sender, e) => OpenForm2(23);
            button1.Click += (sender, e) => OpenForm2(0);
            button2.Click += (sender, e) => OpenForm2(1);
            button3.Click += (sender, e) => OpenForm2(2);
            button4.Click += (sender, e) => OpenForm2(3);
            button5.Click += (sender, e) => OpenForm2(4);
            button6.Click += (sender, e) => OpenForm2(5);
            button7.Click += (sender, e) => OpenForm2(6);
            button8.Click += (sender, e) => OpenForm2(7);
            button9.Click += (sender, e) => OpenForm2(8);
            button10.Click += (sender, e) => OpenForm2(9);
            button11.Click += (sender, e) => OpenForm2(10);
            button12.Click += (sender, e) => OpenForm2(11);
            button13.Click += (sender, e) => OpenForm2(12);
            button14.Click += (sender, e) => OpenForm2(13);
            button15.Click += (sender, e) => OpenForm2(14);
            button16.Click += (sender, e) => OpenForm2(15);
            button17.Click += (sender, e) => OpenForm2(16);
            button18.Click += (sender, e) => OpenForm2(17);
            button19.Click += (sender, e) => OpenForm2(18);
            button20.Click += (sender, e) => OpenForm2(19);
            button21.Click += (sender, e) => OpenForm2(20);
            button22.Click += (sender, e) => OpenForm2(21);
            button23.Click += (sender, e) => OpenForm2(22);
            button24.Click += (sender, e) => OpenForm2(23);

            label1.Click += (sender, e) => OpenForm2(0);
            label2.Click += (sender, e) => OpenForm2(1);
            label3.Click += (sender, e) => OpenForm2(2);
            label4.Click += (sender, e) => OpenForm2(3);
            label5.Click += (sender, e) => OpenForm2(4);
            label6.Click += (sender, e) => OpenForm2(5);
            label7.Click += (sender, e) => OpenForm2(6);
            label8.Click += (sender, e) => OpenForm2(7);
            label9.Click += (sender, e) => OpenForm2(8);
            label10.Click += (sender, e) => OpenForm2(9);
            label11.Click += (sender, e) => OpenForm2(10);
            label12.Click += (sender, e) => OpenForm2(11);
            label13.Click += (sender, e) => OpenForm2(12);
            label14.Click += (sender, e) => OpenForm2(13);
            label15.Click += (sender, e) => OpenForm2(14);
            label16.Click += (sender, e) => OpenForm2(15);
            label17.Click += (sender, e) => OpenForm2(16);
            label18.Click += (sender, e) => OpenForm2(17);
            label19.Click += (sender, e) => OpenForm2(18);
            label20.Click += (sender, e) => OpenForm2(19);
            label21.Click += (sender, e) => OpenForm2(20);
            label22.Click += (sender, e) => OpenForm2(21);
            label23.Click += (sender, e) => OpenForm2(22);
            label24.Click += (sender, e) => OpenForm2(23);
        }

        private void OpenForm2(int index)
        {
            if (form7 == null) form7 = new Form7();
            if (form6 == null) form6 = new Form6();
            Form2 form2 = new Form2(images[index], labels[index], form7, form6);
            form2.Show();
        }

        public void ReceiveData(string text, int index)
        {
            receivedText = text;
            receivedIndex = index;
        }

        private void вхідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSignedIn)
            {
                Form10 form10 = new Form10(receivedText, receivedIndex);
                form10.Show();
            }
        }

        public void UpdateAppearance(Color backgroundColor, int textSize, Color textColor)
        {
            this.BackgroundColor = backgroundColor;
            this.TextSize = textSize;
            this.TextColor = textColor;
            this.BackColor = backgroundColor;

            if (ContextMenuStrip != null)
            {
                ContextMenuStrip.BackColor = backgroundColor;
                ContextMenuStrip.ForeColor = textColor;
            }

            menuStrip1.BackColor = backgroundColor;
            menuStrip1.ForeColor = textColor;
            tabControl1.BackColor = backgroundColor;
            tabControl1.ForeColor = textColor;
            tabPage1.BackColor = backgroundColor;
            tabPage1.ForeColor = textColor;
            tabPage2.BackColor = backgroundColor;
            tabPage2.ForeColor = textColor;
            button1.BackColor = backgroundColor;
            button2.BackColor = backgroundColor;
            button3.BackColor = backgroundColor;
            button4.BackColor = backgroundColor;
            button5.BackColor = backgroundColor;
            button6.BackColor = backgroundColor;
            button7.BackColor = backgroundColor;
            button8.BackColor = backgroundColor;
            button9.BackColor = backgroundColor;
            button10.BackColor = backgroundColor;
            button11.BackColor = backgroundColor;
            button12.BackColor = backgroundColor;
            button13.BackColor = backgroundColor;
            button14.BackColor = backgroundColor;
            button15.BackColor = backgroundColor;
            button16.BackColor = backgroundColor;
            button17.BackColor = backgroundColor;
            button18.BackColor = backgroundColor;
            button19.BackColor = backgroundColor;
            button20.BackColor = backgroundColor;
            button21.BackColor = backgroundColor;
            button22.BackColor = backgroundColor;
            button23.BackColor = backgroundColor;
            button24.BackColor = backgroundColor;
            label1.ForeColor = textColor;
            label1.Font = new Font(label1.Font.FontFamily, textSize);
            label2.ForeColor = textColor;
            label2.Font = new Font(label2.Font.FontFamily, textSize);
            label3.ForeColor = textColor;
            label3.Font = new Font(label3.Font.FontFamily, textSize);
            label4.ForeColor = textColor;
            label4.Font = new Font(label4.Font.FontFamily, textSize);
            label5.ForeColor = textColor;
            label5.Font = new Font(label5.Font.FontFamily, textSize);
            label6.ForeColor = textColor;
            label6.Font = new Font(label6.Font.FontFamily, textSize);
            label7.ForeColor = textColor;
            label7.Font = new Font(label7.Font.FontFamily, textSize);
            label8.ForeColor = textColor;
            label8.Font = new Font(label8.Font.FontFamily, textSize);
            label9.ForeColor = textColor;
            label9.Font = new Font(label9.Font.FontFamily, textSize);
            label10.ForeColor = textColor;
            label10.Font = new Font(label10.Font.FontFamily, textSize);
            label11.ForeColor = textColor;
            label11.Font = new Font(label11.Font.FontFamily, textSize);
            label12.ForeColor = textColor;
            label12.Font = new Font(label12.Font.FontFamily, textSize);
            label13.ForeColor = textColor;
            label13.Font = new Font(label13.Font.FontFamily, textSize);
            label14.ForeColor = textColor;
            label14.Font = new Font(label14.Font.FontFamily, textSize);
            label15.ForeColor = textColor;
            label15.Font = new Font(label15.Font.FontFamily, textSize);
            label16.ForeColor = textColor;
            label16.Font = new Font(label16.Font.FontFamily, textSize);
            label17.ForeColor = textColor;
            label17.Font = new Font(label17.Font.FontFamily, textSize);
            label18.ForeColor = textColor;
            label18.Font = new Font(label18.Font.FontFamily, textSize);
            label19.ForeColor = textColor;
            label19.Font = new Font(label19.Font.FontFamily, textSize);
            label20.ForeColor = textColor;
            label20.Font = new Font(label20.Font.FontFamily, textSize);
            label21.ForeColor = textColor;
            label21.Font = new Font(label21.Font.FontFamily, textSize);
            label22.ForeColor = textColor;
            label22.Font = new Font(label22.Font.FontFamily, textSize);
            label23.ForeColor = textColor;
            label23.Font = new Font(label23.Font.FontFamily, textSize);
            label24.ForeColor = textColor;
            label24.Font = new Font(label24.Font.FontFamily, textSize);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Top -= e.NewValue - e.OldValue;
            }
        }

        private void вхідToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            isSignedIn = true;
            Form4 form4 = new Form4(this);
            form4.Show();
        }

        private void реєстраціяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isSignedIn = true;
            Form5 form5 = new Form5(this);
            form5.Show();
        }

        private void кастомізаціяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(this);
            form8.Show();
        }

        private void вибранеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form6 == null || form6.IsDisposed)
            {
                form6 = new Form6();
            }
            form6.Show();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {

        }

        private void кошикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form7 == null || form7.IsDisposed)
            {
                form7 = new Form7();
            }
            form7.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
