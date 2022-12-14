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
    public partial class rlekerdez : UserControl
    {
        SailorsContext sailorsContext = new SailorsContext();
        public rlekerdez()
        {
            InitializeComponent();
        }

        private void rlekerdez_Load(object sender, EventArgs e)
        {
            var textchanged = from x in sailorsContext.Order
                              where x.OrderId == (Convert.ToInt32(textBox1.Text))
                              select x;
            listBox1.DataSource = textchanged.ToList();
            listBox1.DisplayMember = "OrderId";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var textchanged = from x in sailorsContext.Order
                              where x.OrderId==(Convert.ToInt32(textBox1.Text))
                              select x;
            listBox1.DataSource = textchanged.ToList();
            listBox1.DisplayMember = "OrderId";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = (Order)listBox1.SelectedItem;
            label2.Text = (i.OwnerFkNavigation.Name);
            label3.Text = Convert.ToString(i.BoatFkNavigation.BoatName);
            label4.Text = Convert.ToString(i.Db);
            label5.Text = Convert.ToString(i.Active);
        }
    }
}
