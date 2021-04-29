using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfDataService
{
    public class Service1 : IService1
    {
        string connectionString = ConfigurationManager.ConnectionStrings["TestDataConnectionString"].ConnectionString.ToString();
        
        public List<PersonInfo> GetPesrsonInfoData()
        {
            DataTable dttable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("select * from TestInfoData", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dttable);
                    conn.Close();
                }
            }

            List<PersonInfo> _data = new List<PersonInfo>();
            for (int i = 0; i < dttable.Rows.Count; i++)
            {
                PersonInfo mydata = new PersonInfo();
                mydata.FirstName = Convert.ToString(dttable.Rows[i]["FirstName"]);
                mydata.LastName = Convert.ToString(dttable.Rows[i]["LastName"]);
                mydata.Email = Convert.ToString(dttable.Rows[i]["Email"]);
                mydata.Gender = Convert.ToString(dttable.Rows[i]["Gender"]);
                _data.Add(mydata);
            }

            return _data;
        }
    }
}
