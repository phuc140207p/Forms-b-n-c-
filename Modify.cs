using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace forms_bán_cá
{
    internal class Modify
    {
        public Modify()
        {
        }
        SqlCommand sqlCommand; //dung de truy van cac cau lenh insert,update,dele,....
        SqlDataReader dataReader; //dung de doc du lieu trong bang

        public List<taikhoan> taikhoans(string query)//check tai khoan
        {
            List<taikhoan> taikhoans = new List<taikhoan>();
            using (SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taikhoans.Add(new taikhoan(dataReader.GetString(0),dataReader.GetString(0)));
                }

                sqlConnection.Close();
            }

            return taikhoans;
        }

          public void command(string query) //dung de dang ki tai khoan 
        {
            using (SqlConnection sqlConnection=connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();//thuc thy cau truy van
                sqlConnection.Close ();
            }
        }
        
    }
}
