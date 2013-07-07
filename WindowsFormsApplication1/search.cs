using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication1
{
    class search:DBConnect
    {
        public void Bind(DataGridView dataGridView, string tableName,string field,string data)  //search data from a field and return data to datagridview
        {
            try
            {

                string query = "SELECT * FROM " + tableName + " WHERE " + field + " = '" + data + "'";

                mySqlDataAdapter = new MySqlDataAdapter(query, con);
                mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

                mySqlDataAdapter.UpdateCommand = mySqlCommandBuilder.GetUpdateCommand();
                mySqlDataAdapter.DeleteCommand = mySqlCommandBuilder.GetDeleteCommand();
                mySqlDataAdapter.InsertCommand = mySqlCommandBuilder.GetInsertCommand();

                dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);

                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dataGridView.DataSource = bindingSource;

            }

            catch(MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}
