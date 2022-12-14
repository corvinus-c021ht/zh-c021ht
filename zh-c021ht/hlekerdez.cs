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
    public partial class hlekerdez : UserControl
    {
        SailorsContext sailorsContext = new SailorsContext();
        public hlekerdez()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var textchanged = from x in sailorsContext.Boat
                              where x.BoatName.Contains(textBox1.Text)
                              select x;
            listBox1.DataSource = textchanged.ToList();
            listBox1.DisplayMember = "BoatName";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = (Boat)listBox1.SelectedItem;
            label2.Text =(i.BoatName);
            label3.Text = Convert.ToString(i.OwnerFk);
        }

        private void hlekerdez_Load(object sender, EventArgs e)
        {
            var textchanged = from x in sailorsContext.Boat
                              where x.BoatName.Contains(textBox1.Text)
                              select x;
            listBox1.DataSource = textchanged.ToList();
            listBox1.DisplayMember = "BoatName";
        }
    }
}
