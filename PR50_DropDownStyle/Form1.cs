namespace PR50_DropDownStyle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Test 1");
            comboBox1.Items.Add("Test 2");
            comboBox1.Items.Add("Test 3");
            comboBox1.SelectedItem = "Test 3";
        }
    }
}
