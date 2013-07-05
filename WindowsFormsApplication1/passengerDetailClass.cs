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
        public override List<string>[] Select()
        {
            string query = "SELECT * FROM passenger_detail";

            List<string>[] list = new List<string>[22];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();
            list[7] = new List<string>();
            list[8] = new List<string>();
            list[9] = new List<string>();
            list[10] = new List<string>();
            list[11] = new List<string>();
            list[12] = new List<string>();
            list[13] = new List<string>();
            list[14] = new List<string>();
            list[15] = new List<string>();
            list[16] = new List<string>();
            list[17] = new List<string>();
            list[18] = new List<string>();
            list[19] = new List<string>();
            list[20] = new List<string>();
            list[21] = new List<string>();



            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["client_ID"] + "");
                    list[1].Add(dataReader["first_name"] + "");
                    list[2].Add(dataReader["last_name"] + "");
                    list[3].Add(dataReader["father_name"] + "");
                    list[4].Add(dataReader["passport"] + "");
                    list[5].Add(dataReader["dob"] + "");
                    list[6].Add(dataReader["age"] + "");
                    list[7].Add(dataReader["address"] + "");
                    list[8].Add(dataReader["city"] + "");
                    list[9].Add(dataReader["state"] + "");
                    list[10].Add(dataReader["zip"] + "");
                    list[11].Add(dataReader["phone_no"] + "");
                    list[12].Add(dataReader["nic"] + "");
                    list[13].Add(dataReader["airline_name"] + "");
                    list[14].Add(dataReader["origin"] + "");
                    list[15].Add(dataReader["destination"] + "");
                    list[16].Add(dataReader["duration"] + "");
                    list[17].Add(dataReader["status"] + "");
                    list[18].Add(dataReader["date"] + "");
                    list[19].Add(dataReader["time"] + "");
                    list[20].Add(dataReader["price"] + "");
                    list[21].Add(dataReader["employee"] + "");

                }

                dataReader.Close();

                this.CloseConnection();

                return list;
            }

            else
            {
                return list;
            }
        }



        public override List<string>[] Select(string field,string data)
        {
            string query = "SELECT * FROM passenger_detail WHERE "+field+" = "+data+"";

            List<string>[] list = new List<string>[22];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();
            list[7] = new List<string>();
            list[8] = new List<string>();
            list[9] = new List<string>();
            list[10] = new List<string>();
            list[11] = new List<string>();
            list[12] = new List<string>();
            list[13] = new List<string>();
            list[14] = new List<string>();
            list[15] = new List<string>();
            list[16] = new List<string>();
            list[17] = new List<string>();
            list[18] = new List<string>();
            list[19] = new List<string>();
            list[20] = new List<string>();
            list[21] = new List<string>();



            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["client_ID"] + "");
                    list[1].Add(dataReader["first_name"] + "");
                    list[2].Add(dataReader["last_name"] + "");
                    list[3].Add(dataReader["father_name"] + "");
                    list[4].Add(dataReader["passport"] + "");
                    list[5].Add(dataReader["dob"] + "");
                    list[6].Add(dataReader["age"] + "");
                    list[7].Add(dataReader["address"] + "");
                    list[8].Add(dataReader["city"] + "");
                    list[9].Add(dataReader["state"] + "");
                    list[10].Add(dataReader["zip"] + "");
                    list[11].Add(dataReader["phone_no"] + "");
                    list[12].Add(dataReader["nic"] + "");
                    list[13].Add(dataReader["airline_name"] + "");
                    list[14].Add(dataReader["origin"] + "");
                    list[15].Add(dataReader["destination"] + "");
                    list[16].Add(dataReader["duration"] + "");
                    list[17].Add(dataReader["status"] + "");
                    list[18].Add(dataReader["date"] + "");
                    list[19].Add(dataReader["time"] + "");
                    list[20].Add(dataReader["price"] + "");
                    list[21].Add(dataReader["employee"] + "");

                }

                dataReader.Close();

                this.CloseConnection();

                return list;
            }

            else
            {
                return list;
            }
        }
    }
}
