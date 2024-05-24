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
    public class Namirnica : IEntity
    {

        [DisplayName("ID")]
        public int NamirnicaID { get; set; }
        [DisplayName("Naziv")]
        public string Naziv { get; set; }
        [DisplayName("Alergeni")]
        public string Alergeni { get; set; }
        [DisplayName("Kalorije")]
        public int Kalorije { get; set; }

        [Browsable(false)]  
        public string TableName { get => "Namirnica"; }
        [Browsable(false)]
        public string InsertValues => $"('{Naziv}', '{Alergeni}', {Kalorije})";
        [Browsable(false)]
        public string UpdateValues => $"Naziv = '{Naziv}', Alergeni = '{Alergeni}', Kalorije = {Kalorije}";
        [Browsable(false)]
        public string Join => "";
        [Browsable(false)]
        public string Output => "inserted.namirnicaID";
        [Browsable(false)]
        public CrudStatus CrudStatus { get; set; }

        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> namirnice = new List<IEntity>();
            while (reader.Read())
            {
                Namirnica n = new Namirnica();
                n.NamirnicaID = reader.GetInt32(0);
                n.Naziv = reader.GetString(1);
                n.Alergeni = reader.GetString(2);
                n.Kalorije = reader.GetInt32(3);
                namirnice.Add(n);
            }
            return namirnice;
        }

        [Browsable(false)]
        public string SearchQuery { get; set; }

        public override string ToString()
        {
            return Naziv;
        }

        public override bool Equals(object obj)
        {
            return obj is Namirnica n &&
                Naziv == n.Naziv &&
                Alergeni == n.Alergeni &&
                Kalorije == n.Kalorije;
        }

    }
}
