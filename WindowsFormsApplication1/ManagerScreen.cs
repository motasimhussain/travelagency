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
            this.Hide();

            empRec.ShowDialog();

            this.Show();

        }
    }
}
