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
    public partial class ManagerScreen : Form
    {

        

        new_employee newEmp = new new_employee();
        employeeRecords empRec = new employeeRecords();
        customerRecords cRec;
        dailyRep dr;

        public ManagerScreen()
        {
            InitializeComponent();
        }


        private void ManagerScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void ManagerScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            newEmp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            empRec.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are You sure you want to log out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                //do nothing!
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cRec = new customerRecords();
            cRec.Owner = this;
            cRec.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dr = new dailyRep();
            dr.ShowDialog();
        }
    }
}
