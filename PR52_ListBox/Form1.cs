namespace PR52_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String item = listBox1.Text;
            MessageBox.Show(item);
        }
    }
}
