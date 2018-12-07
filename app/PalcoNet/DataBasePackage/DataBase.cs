using PalcoNet.DataBasePackage;
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
        private SqlTransaction currentTransaction = null;

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

        public DataTable Query(String sql)
        {
            try
            {
                Console.WriteLine("::::QUERY::::");
                Console.WriteLine(sql);
                DataTable dt = new DataTable();
                int rowsReturned;
                SqlCommand cmd = connection.CreateCommand();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                SetTransactionToCmd(cmd);

                rowsReturned = sda.Fill(dt);
                Console.WriteLine("{0} Rows returned", rowsReturned);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw new QueryException("Query error", ex);
            }
        }

        public DataTable TypedQuery(String sql, params QueryParameter[] ps)
        {
            try
            {
                Console.WriteLine("::::TYPED QUERY::::");
                Console.WriteLine(sql);
                DataTable dt = new DataTable();
                int rowsReturned;
                SqlCommand cmd = connection.CreateCommand();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                SetTransactionToCmd(cmd);

                foreach (QueryParameter p in ps)
                {
                    p.AgregateA(cmd);
                }
                rowsReturned = sda.Fill(dt);
                Console.WriteLine("{0} Rows returned", rowsReturned);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw new QueryException("Query error", ex);
            }
        }

        public void Procedure(String procName, params Parametro[] ps)
        {
            Console.WriteLine("::::STORE PROCEDURE::::");
            SqlCommand cmd = GetStoreProcedureCmd(procName);
            Console.WriteLine(cmd.CommandText);
            foreach (Parametro p in ps)
            {
                p.AgregateA(cmd);
            }
            try
            {
                cmd.ExecuteNonQuery();
                foreach (Parametro p in ps)
                {
                    p.ObteneResultadoDe(cmd);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw new ProcedureException("Error al ejecutar el procedure " + procName, ex);
            }
        }

        public SqlCommand GetStoreProcedureCmd(String procName)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = String.Format("{0}.{1}", schemaName, procName);
            SetTransactionToCmd(cmd);
            return cmd;
        }

        private void SetTransactionToCmd(SqlCommand cmd)
        {
            if (currentTransaction != null)
            {
                cmd.Transaction = currentTransaction;
            }
        }

        public void WithTransaction(Action action)
        {
            currentTransaction = connection.BeginTransaction();
            try
            {
                Console.WriteLine(">>>>>>>>> TRANSACTION <<<<<<<<<<<<<");
                action();
                currentTransaction.Commit();
                currentTransaction = null;
                Console.WriteLine(">>>>>>> COMMIT TRANSACTION <<<<<<<<");
            }
            catch
            {
                currentTransaction.Rollback();
                currentTransaction = null;
                Console.WriteLine(">>>>>> ROLLBACK TRANSACTION <<<<<<<<");
                throw;
            }

        }

    }

}
