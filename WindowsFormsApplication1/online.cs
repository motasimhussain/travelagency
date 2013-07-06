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
    public partial class online : Form
    {

        search sr = new search();

        public online()
        {
            InitializeComponent();
        }

        private void online_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(maskedTextBox1.Text);
            sr.Bind(dataGridView1,"passenger_detail","passport", maskedTextBox1.Text);

        }
    }
}
