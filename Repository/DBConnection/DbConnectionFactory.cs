﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DBConnection
{
    public class DbConnectionFactory
    {
        private static DbConnectionFactory instance;
        private DbConnection connection = new DbConnection();

        public static DbConnectionFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DbConnectionFactory();
                }
                return instance;
            }
        }
        private DbConnectionFactory()
        {

        }

        public DbConnection GetDbConnection()
        {
            if (!connection.IsReady())
            {
                connection.OpenConnection();
            }
            return connection;
        }



    }
}
