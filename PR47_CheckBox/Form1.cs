namespace PR47_CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String msg = "";

            if(checkBox1.Checked == true )
            {
                msg += "C# Programming\n";
            }
            if(checkBox2.Checked == true )
            {
                msg += "Java Programming\n";
            }
            if (checkBox3.Checked == true)
            {
                msg += "C++ Programming\n";
            }
            if(msg.Length > 0)
            {
                MessageBox.Show("You have selected: \n\n" + msg);
            }
        }
    }
}
