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

    public partial class dailyRep : Form
    {

        passengerDetailClass pdc = new passengerDetailClass();


        public dailyRep()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string>[] dateCheck;

            dateCheck = pdc.Select();

            for (int i = 0; i < dateCheck[0].Count; i++)
            {
                if (dateTimePicker1.Text == dateCheck[18][i])
                {
                    dataGridView1.Rows.Add(dateCheck[1][i], dateCheck[2][i], dateCheck[3][i], dateCheck[4][i], dateCheck[12][i], dateCheck[20][i],dateCheck[21][i]);
                    MessageBox.Show(dateCheck[2][i]);
                }
            }

        }
    }
}
