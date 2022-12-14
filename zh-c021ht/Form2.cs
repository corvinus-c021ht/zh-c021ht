using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zh_c021ht.Models;

namespace zh_c021ht
{
    public partial class Form2 : Form
    {
        SailorsContext sailorsContext = new SailorsContext();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            hlekerdez userControl1 = new hlekerdez();
            panel1.Controls.Add(userControl1);
            userControl1.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            tlekerdez userControl1 = new tlekerdez();
            panel1.Controls.Add(userControl1);
            userControl1.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            vlekerdez userControl1 = new vlekerdez();
            panel1.Controls.Add(userControl1);
            userControl1.Dock = DockStyle.Fill;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            rlekerdez userControl1 = new rlekerdez();
            panel1.Controls.Add(userControl1);
            userControl1.Dock = DockStyle.Fill;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
