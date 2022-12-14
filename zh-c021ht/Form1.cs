using zh_c021ht.Models;

namespace zh_c021ht
{
    public partial class Form1 : Form
    {
        SailorsContext sailorsContext = new SailorsContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}