using Common;
using Common.Model;
using Repository.DBConnection;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class KorisnikRepository 
    {

        public Korisnik Login(Korisnik entity)
        {
            DbConnection conn = DbConnectionFactory.Instance.GetDbConnection();
            SqlCommand command = conn.CreateCommand($"SELECT * FROM Korisnik WHERE Username=@username AND Password=@password");
            command.Parameters.AddWithValue("@username", entity.Username);
            command.Parameters.AddWithValue("@password", entity.Password);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    Korisnik user = new Korisnik();
                    user.KorisnikID = reader.GetInt32(0);
                    user.ImePrezime = reader.GetString(1);
                    user.Username = reader.GetString(2);
                    user.Password = reader.GetString(3);
                    return user;
                }

            }

            throw new Exception("Korisnik ne postoji!");

        }



    }
}
