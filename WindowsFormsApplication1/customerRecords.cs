﻿using System;
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
        search se;

        public customerRecords()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = TransparencyKey;
            this.BackColor = Color.Black;
            this.TransparencyKey = BackColor; 
        }

        private void customerRecords_Load(object sender, EventArgs e)
        {
            db.Bind(dataGridView1, "passenger_detail");
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;





            button5.Enabled = false;
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
            if (tabControl1.SelectedTab  == tabPage1)
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
            else if (tabControl1.SelectedTab == tabPage2)
            {
                var result = MessageBox.Show("Do you really want to delete this entry?\n This will remove the entire row! \n This is an irrecoverable process!", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
                    {
                        dataGridView2.Rows.RemoveAt(item.Index);
                    }
                }

                db.Save();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            se = new search();
            if(radioButton1.Checked == true && textBox1.Text != "")
            {
                se.Bind(dataGridView2,"passenger_detail","first_name",textBox1.Text);
            }
            else if (radioButton2.Checked == true && textBox1.Text != "")
            {
                se.Bind(dataGridView2, "passenger_detail", "nic", textBox1.Text);
            }
            else if (radioButton3.Checked == true && textBox1.Text != "")
            {
                se.Bind(dataGridView2, "passenger_detail", "passport", textBox1.Text);
            }
            else if (radioButton4.Checked == true && textBox1.Text != "")
            {
                se.Bind(dataGridView2, "passenger_detail", "airline_name", textBox1.Text);
            }
            else if (radioButton5.Checked == true && textBox1.Text != "")
            {
                se.Bind(dataGridView2, "passenger_detail", "destination", textBox1.Text);
            }

            if (textBox1.Text != "")
            {
                tabControl1.SelectedTab = tabPage2;
            }

            button5.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabPage1.Show();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)                                             //using enter to press a button
            {
                button1.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                button2.PerformClick();
            }
        }
    }
}
