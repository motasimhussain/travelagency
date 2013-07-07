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



        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;
            const int WM_NCLBUTTONDBLCLK = 0x00A3; //double click on a title bar a.k.a. non-client area of the form

            switch (m.Msg)
            {
                case WM_SYSCOMMAND: //preventing the form from being moved by the mouse.
                    int command = m.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            if (m.Msg == WM_NCLBUTTONDBLCLK)
            //preventing the form being resized by the mouse double click on the title bar.
            {
                m.Result = IntPtr.Zero;
                return;
            }

            base.WndProc(ref m);
        }



       

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

            airInf.Show();
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
