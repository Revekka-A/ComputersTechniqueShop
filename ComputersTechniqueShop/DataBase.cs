using System.Data.SqlClient;

namespace WFAprepearing
{
    internal class DataBase
    {
        SqlConnection connection = new SqlConnection(@"Data source = ADCLG1; initial catalog = AndreevaShop2; integrated security = true");

        public void OpenCon()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void CloseCon()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public SqlConnection getCon() { return connection; }
    }
}
