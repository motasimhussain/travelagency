using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Passengerdetail : Form
    {
        //passengerDetailClass pd = new passengerDetailClass();

        Flightentry fe;

        public Passengerdetail()
        {
            InitializeComponent();

            //fe = new Flightentry(f_name.Text, l_name.Text, father_name.Text, dob.Text, age.Text, address.Text, city.Text, state.Text, zip.Text, phone.Text, nic.Text);

            //fe.FormClosed += new FormClosedEventHandler(fe_FormClosed);
        }

        void fe_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Passengerdetail_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            fe = new Flightentry(f_name.Text, l_name.Text, father_name.Text, dob.Text, age.Text, address.Text, city.Text, state.Text, zip.Text, phone.Text, nic.Text);
            this.Hide();
            fe.Owner = this;
            fe.ShowDialog();
            this.Show();
        }

        private void Passengerdetail_Shown(object sender, EventArgs e)
        {

        }
        
    }
     
}
