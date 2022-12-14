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
    public partial class UserControl1 : UserControl
    {
        SailorsContext sailorsContext = new SailorsContext();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            //listBox1.DataSource=
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int boatid =Convert.ToInt32( textBox1.Text);
            var Boatname = textBox2.Text;
            var tulaj = listBox1.SelectedItem;

            Boat ujhajo = new Boat();
            ujhajo.BoatId = boatid;
            ujhajo.BoatName = Boatname;
            //ujhajo.OwnerFk = tulaj;
            sailorsContext.Boat.Add(ujhajo);
            try
            {
                sailorsContext.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            bindingSource1.DataSource = sailorsContext.Boat.ToList();
        }
    }
}
