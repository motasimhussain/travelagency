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
    public partial class EmployeeScreen : Form
    {

        //Flightentry fe = new Flightentry();
        Passengerdetail pd = new Passengerdetail();
       

        public EmployeeScreen()
        {

            InitializeComponent();
        }




        private void EmployeeScreen_Load(object sender, EventArgs e)
        {
            
        }

        public void button5_Click(object sender, EventArgs e)
        {
            //this.Hide();                                        //open passenger details
            pd.Owner = this;
            pd.ShowDialog();
            //this.Show();
        }

        private void EmployeeScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are You sure you want to log out?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else 
            {
                //do nothing!
            }
        }
    }
}
