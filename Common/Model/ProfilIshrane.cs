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
    public class ProfilIshrane : IEntity
    {
        public int ReceptID { get; set; }
        public int VrstaJelaID { get; set; }
        public string Naziv { get; set; }

        public string TableName { get => "ProfilIshrane"; }

        public string InsertValues => $"({ReceptID}, {VrstaJelaID}, '{Naziv}')";

        public string UpdateValues => $" Naziv = '{Naziv}' ";

        public string Join => "join Recept r on ProfilIshrane.ReceptID = r.ReceptID join VrstaJela vj on vj.VrstaJelaID = ProfilIshrane.VrstaJelaID";

        public string Output => "inserted.ReceptID";

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> profiliIshrane = new List<IEntity>();

            while (reader.Read())
            {
                ProfilIshrane pi = new ProfilIshrane();

                pi.ReceptID = reader.GetInt32(0);
                pi.VrstaJelaID = reader.GetInt32(1);
                pi.Naziv = reader.GetString(2);

                profiliIshrane.Add(pi); 
                
            }
            return profiliIshrane;
        }

        [Browsable(false)]
        public CrudStatus CrudStatus { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
