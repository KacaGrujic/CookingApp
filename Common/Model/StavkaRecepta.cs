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
    public class StavkaRecepta : IEntity
    {
        [Browsable(false)]
        public int StavkeReceptaID { get; set; }
        [Browsable(false)]
        public int ReceptID { get; set; }
        [DisplayName("Namirnica")]
        public Namirnica Namirnica { get; set; }
        [DisplayName("Kolicina")]
        public int Kolicina { get; set; }
        [DisplayName("Merna jedinica")]
        public MernaJedinica MernaJedinica { get; set; }

        [Browsable(false)]
        public int UkupneKalorije = 0;
        [Browsable(false)]
        public string TableName => "StavkeRecepta";
        [Browsable(false)]
        public string InsertValues => $"({ReceptID}, {Kolicina}, '{MernaJedinica}', {Namirnica.NamirnicaID})";
        [Browsable(false)]
        public string UpdateValues => $" Kolicina = {Kolicina}, MernaJedinica = '{MernaJedinica}', NamirnicaID = {Namirnica.NamirnicaID}";
        [Browsable(false)]
        public string Join => "join Namirnica n on n.NamirnicaID = StavkeRecepta.NamirnicaID join Recept r on StavkeRecepta.receptID = r.receptID";
        [Browsable(false)]
        public string Output => "inserted.ReceptID";
        [Browsable(false)]
        public List<IEntity> GetList(SqlDataReader reader)
        {
           List<IEntity> stavkeRecepta = new List<IEntity>();

            while (reader.Read())
            {
                StavkaRecepta sr = new StavkaRecepta();
                sr.StavkeReceptaID = reader.GetInt32(0);
                sr.ReceptID =  reader.GetInt32(1);
                sr.Kolicina = reader.GetInt32(2);
                sr.MernaJedinica = (MernaJedinica)Enum.Parse(typeof(MernaJedinica), reader.GetString(3));
                sr.Namirnica = new Namirnica
                {
                    NamirnicaID = reader.GetInt32(5),
                    Naziv = reader.GetString(6),
                    Alergeni = reader.GetString(7),
                    Kalorije = reader.GetInt32(8)
                };
                stavkeRecepta.Add(sr);
            }
            return stavkeRecepta;
        }


        [Browsable(false)]
        public int UkupneKalorijeBeforeUpdate { get; set; }

        [Browsable(false)]
        public CrudStatus CrudStatus { get; set; }
        [Browsable(false)]
        public string SearchQuery { get; set; }


    }
}
