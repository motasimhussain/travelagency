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
    public partial class salesRecord : Form
    {
        string employee;
        search se;
        passengerDetailClass pd = new passengerDetailClass();
        double total = 0;

        public salesRecord(string user)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = TransparencyKey;
            this.BackColor = Color.Black;
            this.TransparencyKey = BackColor;

            employee = user;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salesRecord_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            se = new search();

            textBox1.Clear();
            total = 0;

            se.Bind(dataGridView1, "passenger_detail", "employee", employee);

            List<string>[] addPrice;

            addPrice = pd.Select();

            for (int i = 0; i < addPrice[0].Count; i++)
            {
                total = total + double.Parse(addPrice[20][i]);

                textBox1.Text = total.ToString();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
