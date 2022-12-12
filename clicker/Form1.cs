namespace clicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int licznik = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            licznik++;
            label2.Text =  licznik.ToString();

            if (licznik == 100)
            {
                label3.Text = "🤡";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}