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
    public partial class splashScreen : Form
    {

        login_form login = new login_form();


        public splashScreen()
        {
            
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = TransparencyKey;
            this.BackColor = Color.White;                               
            this.TransparencyKey = BackColor;                           // Make the background color of form display transparently.



            login.FormClosed += new FormClosedEventHandler(login_FormClosed);

        

        }

        void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void splashScreen_Load(object sender, EventArgs e)
        {
            this.Opacity = 1;

            //if (timer1.Interval == 2000)
            //{
            //    login_form login = new login_form();
            //    login.Show();
            //    this.Hide();
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += -0.03;

            if (this.Opacity == 0)
            {
                login.Show();
                
                timer1.Stop();
                this.Hide();
            }
        }
    }
}
