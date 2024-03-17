namespace PR42_LabelClickEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hi";
            label1.Font = new Font("Arial", 16);
        }
    }
}
