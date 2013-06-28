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
    public partial class customerRecords : Form
    {

        DBConnect db = new DBConnect();

        public customerRecords()
        {
            InitializeComponent();
        }

        private void customerRecords_Load(object sender, EventArgs e)
        {
            db.Bind(dataGridView1, "passenger_detail");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Columns[0].ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.Save();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you really want to delete this entry?\n This will remove the entire row! \n This is an irrecoverable process!", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                }
            }

            db.Save();
        }
    }
}
