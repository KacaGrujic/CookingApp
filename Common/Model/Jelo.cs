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
    public class Jelo : IEntity
    {
        [DisplayName("ID")]
        public int JeloID { get; set; }
        [DisplayName("Naziv")]
        public string Naziv { get; set; }
        [DisplayName("Vrsta jela")]
        public VrstaJela VrstaJela { get; set; }
        [DisplayName("Kuhinja")]
        public string Kuhinja { get; set; }

        [Browsable(false)]
        public CrudStatus CrudStatus { get; set; }
        [Browsable(false)]
        public string TableName { get => "Jelo"; }
        [Browsable(false)]
        public string InsertValues => $"('{Naziv}', '{VrstaJela.VrstaJelaID}', '{Kuhinja}' )";
        [Browsable(false)]
        public string UpdateValues => $" Naziv = '{Naziv}', VrstaJela = {VrstaJela.VrstaJelaID}, Kuhinja = '{Kuhinja}'";
        [Browsable(false)]
        public string Join => " join VrstaJela vj on Jelo.VrstaJela = vj.VrstaJelaID";
        [Browsable(false)]
        public string Output => "inserted.JeloID";
        [Browsable(false)]
        public string SearchQuery { get; set; }

        [Browsable(false)]
        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> jela = new List<IEntity>();

            while (reader.Read())
            {
                Jelo j = new Jelo();
                j.JeloID = reader.GetInt32(0);
                j.Naziv = reader.GetString(1);
                j.VrstaJela = new VrstaJela { VrstaJelaID = reader.GetInt32(2), Naziv = reader.GetString(5) };
                j.Kuhinja = reader.GetString(3);

                jela.Add(j);
            }
            return jela;
        }

        public override bool Equals(object obj)
        {
            return obj is Jelo jelo &&
                JeloID == jelo.JeloID &&
                Naziv == jelo.Naziv &&
                VrstaJela == jelo.VrstaJela &&
                Kuhinja == jelo.Kuhinja;
        }

        public override string ToString()
        {
            return Naziv;
        }

    }
}
