namespace PR40_MouseLeaveEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
        }
    }
}
