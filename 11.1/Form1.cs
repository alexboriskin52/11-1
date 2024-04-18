namespace _11._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int p = 3;
        int n = 1;
        string sumLoop1;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 100;
            label1.Text = trackBar1.Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = trackBar1.Value;
            int sumLoop = 0;
            for (int i = 0; i <= n; i++)
            {
                sumLoop += p + i;
            }
            sumLoop1 = $"{(sumLoop / p)}*p";
            label3.Text = sumLoop1.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            n = trackBar1.Value;
            double sumLoop = (n + 1) * (2 * p + n) / 2.0;
            sumLoop1 = $"{(sumLoop / p)}*p";
            label4.Text = sumLoop1.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
