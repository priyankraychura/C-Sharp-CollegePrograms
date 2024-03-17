namespace PR51_ComboBoxSelectedIndexChanged
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("WeekDays");
            comboBox1.Items.Add("Years");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if(comboBox1.SelectedItem == "WeekDays")
            {
                comboBox2.Items.Add("Sunday");
                comboBox2.Items.Add("Monday");
                comboBox2.Items.Add("Tuesday");
            } else if(comboBox1.SelectedItem == "Years"){
                comboBox2.Items.Add("2021");
                comboBox2.Items.Add("2022");
                comboBox2.Items.Add("2023");
                comboBox2.Items.Add("2024");
            }
        }
    }
}
