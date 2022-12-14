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
    public partial class vlekerdez : UserControl
    {
        SailorsContext sailorsContext = new SailorsContext();
        public vlekerdez()
        {
            InitializeComponent();
        }

        private void vlekerdez_Load(object sender, EventArgs e)
        {
            var textchanged = from x in sailorsContext.Sails
                              where x.SailName.Contains(textBox1.Text)
                              select x;
            listBox1.DataSource = textchanged.ToList();
            listBox1.DisplayMember = "SailName";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var textchanged = from x in sailorsContext.Sails
                              where x.SailName.Contains(textBox1.Text)
                              select x;
            listBox1.DataSource = textchanged.ToList();
            listBox1.DisplayMember = "SailName";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = (Sails)listBox1.SelectedItem;
            label2.Text = (i.SailName);
            label3.Text = Convert.ToString(i.SailId);
            label4.Text = Convert.ToString(i.Price);
            label5.Text = Convert.ToString(i.Db);
        }
    }
}
