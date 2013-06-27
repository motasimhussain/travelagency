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
    public partial class Flightentry : Form
    {

        flightDetail fd = new flightDetail();

        //private Passengerdetail pd;

        string f_name;
        string l_name; 
        string father_name;
        string dob;
        string age;
        string address;
        string city;
        string state;
        string zip;
        string phone;
        string nic;

        //public Flightentry(Passengerdetail paDet)
        public Flightentry(string f_name,string l_name,string father_name,string dob,string age,string address,string city,string state,string zip,string phone,string nic)
        {
            InitializeComponent();



            this.f_name = f_name;
            this.l_name = l_name;
            this.father_name = father_name;
            this.dob = dob;
            this.age = age;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phone = phone;
            this.nic = nic;
            //pd = paDet;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            //pd.insertData();

            MessageBox.Show(f_name);

            fd.Insert(f_name, l_name, father_name, dob, age, address, city, state, zip, phone, nic, comboBox1.Text, comboBox2.Text, comboBox3.Text, textBox3.Text, textBox8.Text, dateTimePicker1.Text, textBox6.Text, textBox5.Text);
        }

        private void Flightentry_Load(object sender, EventArgs e)
        {

        }

        private void Flightentry_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void Flightentry_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Close();
        }
    }
}
