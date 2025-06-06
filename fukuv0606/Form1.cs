namespace fukuv0606
{
    public partial class Form1 : Form
    {
        int vx = -4;
        int vy = +4;
        int spead = 1;
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
                spead += 200;
                vx = -vx + spead;
                label1.Left = 0;
            }
            else if (label1.Right > this.ClientSize.Width)
            {
                spead += 200;
                vx = -vx;
                label1.Left = this.ClientSize.Width - label1.Width;
            }
            if (label1.Top < 0)
            {
                spead += 200;
                vy = -vy;
                label1.Top = 0;
            }
            else if (label1.Bottom > this.ClientSize.Height)
            {
                spead += 200;
                vy = -vy;
                label1.Top = this.ClientSize.Height - label1.Height;
            }
        }
    }
}
