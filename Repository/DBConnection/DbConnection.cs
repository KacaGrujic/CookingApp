using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DBConnection
{
    public class DbConnection
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public void OpenConnection()
        {
            if (!IsReady())
            {
                connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Seminarski;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                connection.Open();
            }
        }

        public SqlCommand CreateCommand(string sql = "")
        {
            if (transaction?.Connection == null)
                transaction = connection.BeginTransaction();
            return new SqlCommand(sql, connection, transaction);
        }
        public void Commit()
        {
            transaction.Commit();
        }
        public void Rollback()
        {
            transaction.Rollback();
        }
        public bool IsReady()
        {
            return connection != null && connection.State != ConnectionState.Closed;
        }
        public void Close()
        {
            connection.Close();
        }
    }
}

