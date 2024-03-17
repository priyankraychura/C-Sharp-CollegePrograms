namespace PR36_EventArgs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            label1.Text = "Mouse Clicked at: " + x + " " + y;
        }
    }
}
