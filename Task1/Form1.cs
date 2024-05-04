namespace Task1
{
    public partial class Form1 : Form
    {
        private double angle = 0;
        private int radius = 100;
        private int speed = 1;

        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            angle += speed;
            if (angle >= 360 | angle <= -360) angle = 0;
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int x = (int)(radius * Math.Cos(angle * Math.PI / 180)) + pictureBox1.Width / 2;
            int y = (int)(radius * Math.Sin(angle * Math.PI / 180)) + pictureBox1.Height / 2;
            e.Graphics.FillEllipse(Brushes.Red, x, y, 10, 10);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                speed = trackBar1.Value;
            else if (radioButton2.Checked)
                speed = -trackBar1.Value;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            speed = trackBar1.Value;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            speed = -trackBar1.Value;
        }
    }
}
