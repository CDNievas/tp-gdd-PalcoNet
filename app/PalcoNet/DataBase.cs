using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet
{
    class DataBase
    {
        private const String schemaName = "COMPUMUNDOHIPERMEGARED";
        private static DataBase instance = null;
        private SqlConnection connection;
        
        private DataBase()
        {
            connection = new SqlConnection(Properties.Settings.Default.GD2C2018ConnectionString);
            connection.Open();
        }

        public static DataBase GetInstance()
        {
            if (instance == null)
                instance = new DataBase();
            return instance;
        }

        public DataTable query(String sql)
        {
            Console.WriteLine("::::QUERY::::");
            Console.WriteLine(sql);
            DataTable dt = new DataTable();
            int rowsReturned;
            SqlCommand cmd = connection.CreateCommand();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            rowsReturned = sda.Fill(dt);
            Console.WriteLine("{0} Rows returned", rowsReturned);
            return dt;
        }

    }
}
