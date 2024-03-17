namespace PR43_MouseEnterEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Mouse Enter Event";
        }
    }
}
