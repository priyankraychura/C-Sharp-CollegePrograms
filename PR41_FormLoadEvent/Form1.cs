namespace PR41_FormLoadEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label l = new Label();
            l.AutoSize = true;
            l.Text = "Do you want to submit this project?";
            l.Location = new Point(222, 145);
            l.Font = new Font("French Script MT", 18);

            this.Controls.Add(l);

            Button MyButton = new Button();
            MyButton.Location = new Point(255, 198);
            MyButton.Text = "Submit";
            MyButton.AutoSize = true;
            MyButton.BackColor = Color.LightBlue;
            MyButton.Padding = new Padding(6);
            MyButton.Font = new Font("French Script MT", 18);

            this.Controls.Add(MyButton);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Submit";

            MessageBox.Show("Hi");
            button1.BackColor = Color.DarkBlue;
            button1.Location = new Point(200, 300);
            button1.Padding = new Padding(6);
            button1.Font = new Font("French Script MT", 15);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor= Color.IndianRed;
        }
    }
}
