namespace PR53_ListBoxMultiSelection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiSimple;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Object obj in listBox1.SelectedItems)
            {
                MessageBox.Show(obj.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string items = "";

            foreach (var item in listBox1.SelectedItems)
            {
                items += item.ToString() + ", ";
            }

            MessageBox.Show(items);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string items = "";

            foreach (var item in listBox1.Items)
            {
                items += item.ToString() + ", ";
            }

            MessageBox.Show(items);
        }
    }
}
