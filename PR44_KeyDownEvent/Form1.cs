namespace PR44_KeyDownEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("You pressed enter key");
            }
            if (e.KeyCode == Keys.CapsLock)
            {
                MessageBox.Show("You pressed CapsLock key");
            }
        }
    }
}
