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

    public partial class dailyRep : Form
    {

        passengerDetailClass pdc = new passengerDetailClass();
        double total = 0;


        public dailyRep()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = TransparencyKey;
            this.BackColor = Color.Black;
            this.TransparencyKey = BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            total = 0;
            textBox1.Clear();

            List<string>[] dateCheck;

            dateCheck = pdc.Select();

            for (int i = 0; i < dateCheck[0].Count; i++)
            {
                if (dateTimePicker1.Text == dateCheck[18][i])
                {
                    dataGridView1.Rows.Add(dateCheck[1][i], dateCheck[2][i], dateCheck[3][i], dateCheck[4][i], dateCheck[12][i], dateCheck[20][i],dateCheck[21][i]);

                    total = total + double.Parse(dateCheck[20][i]);

                    textBox1.Text = total.ToString();

                    //MessageBox.Show(dateCheck[2][i]);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dailyRep_Load(object sender, EventArgs e)
        {

        }
    }
}
