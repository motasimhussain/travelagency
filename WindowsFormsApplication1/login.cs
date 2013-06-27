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

    

    public partial class login_form : Form
    {

        ManagerScreen mgrForm = new ManagerScreen();
        EmployeeScreen empForm = new EmployeeScreen();
        


        DBConnect db = new DBConnect();


        public login_form()
        {
            InitializeComponent();

            mgrForm.FormClosed += new FormClosedEventHandler(mgrForm_FormClosed);
            empForm.FormClosed += new FormClosedEventHandler(empForm_FormClosed);
        }

        void mgrForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Close();
            this.Show();
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Text = "UserName";
            textBox2.Text = "Password";
            textBox1.Focus();
        }

        void empForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Close();
            this.Show();
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Text = "UserName";
            textBox2.Text = "Password";


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.ReadLine();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Console.ReadLine();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            
            List<string>[] passCheck;

            passCheck = db.Select();

            for (int i = 0; i < passCheck[0].Count; i++)
            {
                

                if (textBox1.Text == passCheck[1][i] && textBox2.Text == passCheck[2][i]) //checking username and pass
                {

                    if (passCheck[3][i].Contains("Admin"))                                //admin evaluation
                    {
                        this.Hide();

                        MessageBox.Show("Admin");

                        mgrForm.Show();
                    }
                    else if (passCheck[3][i].Contains("Employee"))                             //employee evaluation
                    {
                        this.Hide();
                        
                        MessageBox.Show("Employee");
                        
                        empForm.Show();

                    }
                    break;
                }

                else if(i == passCheck[0].Count - 1)                                       //wrong user/pass msg
                {
                    
                    MessageBox.Show("Wrong Password OR User Name");
                    break;
                }

            //dataGridView1.Rows[number].Cells[0].Value = passCheck[0][i];
            //dataGridView1.Rows[number].Cells[1].Value = passCheck[1][i];
            //dataGridView1.Rows[number].Cells[2].Value = passCheck[2][i];

            
            }
           
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)                                             //random stuff =P
            {
                signin.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                cancel.PerformClick();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                signin.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                cancel.PerformClick();
            }
        }
        

    }

}
