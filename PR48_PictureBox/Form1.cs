namespace PR48_PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("E://BCA Sem IV//C#//book1.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
