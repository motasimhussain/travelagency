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
        //Passengerdetail pd;
        salesRecord sr;
        AirlineInfo airInf;
        string employee;

        flightDetail fd = new flightDetail();
        



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
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }

        public void button5_Click(object sender, EventArgs e)
        {
            //this.Hide();                                        //open passenger details
            
            //pd = new Passengerdetail(employee);
            //pd.Show();
            //pd.Owner = this;
            //pd.Show();
            //this.Show();

            tabControl1.Visible = true;

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

        private void button3_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            tabControl1.Visible = false;
        }



        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            tabControl1.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            if (maskedTextBox1.Text != "" && f_name.Text != "" & passport.Text != "" & nic.Text != "")
            {
                tabControl1.SelectedTab = tabPage3;

                textBox1.Text = f_name.Text;
                textBox2.Text = l_name.Text;
                textBox4.Text = father_name.Text;
                textBox5.Text = passport.Text;
                textBox7.Text = dob.Text;
                textBox9.Text = age.Text;
                textBox10.Text = address.Text;
                textBox11.Text = city.Text;
                textBox12.Text = state.Text;
                textBox13.Text = zip.Text;
                textBox14.Text = phone.Text;
                textBox15.Text = nic.Text;
                textBox16.Text = comboBox1.Text;
                textBox17.Text = comboBox2.Text;
                textBox18.Text = comboBox3.Text;
                textBox19.Text = textBox3.Text;
                textBox20.Text = textBox8.Text;
                textBox21.Text = dateTimePicker1.Text;
                textBox22.Text = textBox6.Text;
                textBox23.Text = maskedTextBox1.Text;


            }

            else 
            {
                MessageBox.Show("Enter Valid Data!");
            }

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Enter valid data!");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            fd.Insert(f_name.Text, l_name.Text, father_name.Text, passport.Text, dob.Text, age.Text, address.Text, city.Text, state.Text, zip.Text, phone.Text, nic.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, textBox3.Text, textBox8.Text, dateTimePicker1.Text, textBox6.Text, maskedTextBox1.Text, employee);
        }


    }
}
