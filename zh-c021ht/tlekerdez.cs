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
    public partial class tlekerdez : UserControl
    {
        SailorsContext sailorsContext = new SailorsContext();
        public tlekerdez()
        {
            InitializeComponent();
        }

        private void tlekerdez_Load(object sender, EventArgs e)
        {
            var textchanged = from x in sailorsContext.Owner
                              where x.Name.Contains(textBox1.Text)
                              select x;
            listBox1.DataSource = textchanged.ToList();
            listBox1.DisplayMember = "Name";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var textchanged = from x in sailorsContext.Owner
                              where x.Name.Contains(textBox1.Text)
                              select x;
            listBox1.DataSource = textchanged.ToList();
            listBox1.DisplayMember = "Name";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = (Owner)listBox1.SelectedItem;
            label2.Text = (i.Name);
            label3.Text = Convert.ToString(i.OwnerId);
            label4.Text = Convert.ToString(i.ContactPhone);
        }
    }
}
