using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    class DBAccess
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        void OpenConnection()
        {
            conn.Open();
        }
        void CloseConnection()
        {
            conn.Close();
        }
        public void ExecuteQuery(string query, Hashtable parameters)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            foreach (DictionaryEntry parameter in parameters)
            {
                cmd.Parameters.AddWithValue(parameter.Key.ToString(), parameter.Value);
            }
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void ExecuteQuery(string query)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand(query,conn);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public DataTable GetDataTable(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}