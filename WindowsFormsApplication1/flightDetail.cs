using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    class flightDetail:DBConnect
    {
        public void Insert(string fn , string ln , string fatherName , string dob , string age ,string address,string city,string state,string zip,string phone,string nic,string airline_name, string origin, string destination,string duration,string status,string date,string time, string price)
    {
        string query = "INSERT INTO passenger_detail (first_name,last_name,father_name,dob,age,address,city,state,zip,phone_no,nic,airline_name,origin,destination,duration,status,date,time,price) VALUES ('" + fn + "','" + ln + "','" + fatherName + "','" + dob + "','" + age + "','" + address + "','" + city + "','" + state + "','" + zip + "','" + phone + "','" + nic + "','" + airline_name + "','" + origin + "','" + destination + "','" + duration + "','" + status + "','" + date + "','" + time + "','" + price + "')";

        if (OpenConnection() == true)
        {
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }
    }
    }
}
