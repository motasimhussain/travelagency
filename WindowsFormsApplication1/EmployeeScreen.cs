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
        //Passengerdetail pd = new Passengerdetail();
        Passengerdetail pd;
        salesRecord sr;
        AirlineInfo airInf;
        string employee;
       

        public EmployeeScreen(string uname)
        {
            employee = uname;
            InitializeComponent();
        }




        private void EmployeeScreen_Load(object sender, EventArgs e)
        {
            
        }

        public void button5_Click(object sender, EventArgs e)
        {
            //this.Hide();                                        //open passenger details
            pd = new Passengerdetail(employee);

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

        private void button4_Click(object sender, EventArgs e)
        {
            sr = new salesRecord(employee);
            sr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            airInf = new AirlineInfo();

            airInf.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }
    }
}
