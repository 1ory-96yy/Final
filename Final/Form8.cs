namespace Final
{
    public partial class Form8 : Form
    {
        private Form1 parentForm;
        private Color tcolor;
        private int Tsize=8;

        public Form8(Form1 form1)
        {
            InitializeComponent();
            parentForm = form1;
        }

        public Color BColor { get; private set; }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            BColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            this.BackColor = BColor;
            UpdateButtonColor();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            BColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            this.BackColor = BColor;
            UpdateButtonColor();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            BColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            this.BackColor = BColor;
            UpdateButtonColor();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            tcolor = Color.FromArgb(trackBar4.Value, trackBar5.Value, trackBar6.Value);
            label1.ForeColor = tcolor;
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            tcolor = Color.FromArgb(trackBar4.Value, trackBar5.Value, trackBar6.Value);
            label1.ForeColor = tcolor;
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            tcolor = Color.FromArgb(trackBar4.Value, trackBar5.Value, trackBar6.Value);
            label1.ForeColor = tcolor;
        }

        private void trackBar7_Scroll(object sender, EventArgs e)
        {
            Tsize = trackBar7.Value;
            label1.Font = new Font(label1.Font.FontFamily, Tsize);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parentForm.UpdateAppearance(BColor, Tsize, tcolor);
            this.Close();
        }

        private void UpdateButtonColor()
        {
            if (trackBar1.Value > 10 || trackBar2.Value > 10 || trackBar3.Value > 10)
            {
                button1.BackColor = Color.FromArgb(
                    Math.Max(0, trackBar1.Value - 10),
                    Math.Max(0, trackBar2.Value - 10),
                    Math.Max(0, trackBar3.Value - 10));
            }
            else
            {
                button1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            }
        }
    }
}
