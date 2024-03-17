namespace PR49_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Sunday");
            comboBox1.Items.Add("Monday");
            comboBox1.Items.Add("Tuesday");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String var;
            var = comboBox1.Text;
            var item = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            MessageBox.Show(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String var;
            var = comboBox1.Text;
            var item = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            comboBox1.Items.Remove(item);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String data;
            data = textBox1.Text;
            comboBox1.Items.Add(data);
            textBox1.Text = "";
        }
    }
}
