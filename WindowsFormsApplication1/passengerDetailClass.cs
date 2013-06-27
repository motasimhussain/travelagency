using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class passengerDetailClass:DBConnect
    {
        //public void Insert(string fn , string ln , string fatherName , string dob , string age ,string address,string city,string state,string zip,string phone,string nic)
        //{
        //    string query = "INSERT INTO passenger_detail (first_name,last_name,father_name,dob,age,address,city,state,zip,phone_no,nic) VALUES ('" + fn + "','" + ln + "','" + fatherName + "','" + dob + "','" + age + "','" + address + "','" + city + "','" + state + "','" + zip + "','" + phone + "','" + nic + "')";

        //    if (this.OpenConnection() == true)
        //    {
        //        MySqlCommand cmd = new MySqlCommand(query, con);

        //        cmd.ExecuteNonQuery();

        //        this.CloseConnection();
        //    }
        //}

    }
}
