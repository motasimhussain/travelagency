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
    public partial class AirlineInfo : Form
    {
        public AirlineInfo()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(comboBox1.Text.ToString());
        }

        private void AirlineInfo_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.karachiairport.com.pk/SearchHomeFormattedNew.asp");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }
    }
}
