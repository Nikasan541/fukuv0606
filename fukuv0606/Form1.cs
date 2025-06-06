namespace fukuv0606
{
    public partial class Form1 : Form
    {
        int vx = -4;
        int vy = +4;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "nikaido yuki";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;
            if (label1.Left < 0)
            {
                vx = -vx;
                label1.Left = 0;
            }
            else if (label1.Right > this.ClientSize.Width)
            {
                vx = -vx;
                label1.Left = this.ClientSize.Width - label1.Width;
            }
            if (label1.Top < 0)
            {
                vy = -vy;
                label1.Top = 0;
            }
            else if (label1.Bottom > this.ClientSize.Height)
            {
                vy = -vy;
                label1.Top = this.ClientSize.Height - label1.Height;
            }
        }
    }
}
