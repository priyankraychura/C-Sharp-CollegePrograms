namespace PR39_BtnMouseEnterAndMouseHover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor= Color.Blue;
        }
    }
}
