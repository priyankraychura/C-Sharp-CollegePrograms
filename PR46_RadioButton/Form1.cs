namespace PR46_RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("You have selected Red!");
            }
            else if (radioButton2.Checked == true)
            {
                MessageBox.Show("You have selected Blue!");
            }
            else
            {
                MessageBox.Show("You have selected Green!");
            }
        }
    }
}
