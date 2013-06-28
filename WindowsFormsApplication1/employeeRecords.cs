using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class employeeRecords : Form
    {
        public employeeRecords()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect();
        


        private void employeeRecords_Load(object sender, EventArgs e)
        {

            db.Bind(dataGridView1, "login");
            dataGridView1.AllowUserToAddRows = false;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Columns[0].ReadOnly = true;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you really want to delete this employee?\n This is an irrecoverable process!", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes )
            {
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                }
            }

            db.Save();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void Modify_Click(object sender, EventArgs e)
        {
            db.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
