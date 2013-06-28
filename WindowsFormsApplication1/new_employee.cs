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
    public partial class new_employee : Form
    {

        DBConnect db = new DBConnect();

        public new_employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "Select a member..")
            {
                db.Insert(newUser.Text, newPass.Text, comboBox1.Text,emp_name.Text,last_name.Text,NIC.Text);

                MessageBox.Show("Record Added!!!");

                this.Close();
            }
            else
            {
                MessageBox.Show("Select a member..");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void new_employee_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
