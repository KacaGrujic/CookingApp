using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    [Serializable]
    public class Korisnik : IEntity
    {
        public int KorisnikID { get; set; }
        public string ImePrezime { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string TableName { get => "Korisnik"; }

        public string InsertValues => $"'{ImePrezime}', '{Username}', '{Password}'";

        public string UpdateValues => "";

        public string Join => "";

        public string Output => "";

        [Browsable(false)]
        public CrudStatus CrudStatus { get; set; }

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> korisnici = new List<IEntity>();
            while (reader.Read())
            {
                Korisnik k = new Korisnik();
                k.KorisnikID = reader.GetInt32(0);
                k.ImePrezime = reader.GetString(1);
                k.Username = reader.GetString(2);
                k.Password = reader.GetString(3);

                korisnici.Add(k);
            }
            return korisnici;
        }

        public override bool Equals(object obj)
        {
            return obj is Korisnik korisnik && 
                ImePrezime == korisnik.ImePrezime &&
                Username == korisnik.Username &&
                Password == korisnik.Password;
        }

        public override string ToString()
        {
            return ImePrezime;
        }

    }
}
