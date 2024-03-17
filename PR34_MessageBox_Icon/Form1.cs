namespace PR34_MessageBox_Icon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to C#", "Learn C#", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
    }
}
