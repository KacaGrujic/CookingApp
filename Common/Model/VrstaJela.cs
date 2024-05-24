using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    //public enum VrstaJela
    //{
    //    Predjelo,
    //    GlavnoJelo,
    //    Dezert,
    //    Koktel
    //}
    [Serializable]
    public class VrstaJela : IEntity
    {
        public int VrstaJelaID { get; set; }

        public string Naziv { get; set; }

        public string TableName { get => "VrstaJela"; }

        public string InsertValues => $"'{Naziv}'";

        public string UpdateValues => "";

        public string Join => "";

        public string Output => "";
        [Browsable(false)]
        public CrudStatus CrudStatus { get; set; }


        public List<IEntity> GetList(SqlDataReader reader)
        {
            List<IEntity> vrsteJela = new List<IEntity>();
            while (reader.Read())
            {
                VrstaJela vrsta = new VrstaJela();
                vrsta.VrstaJelaID = (int)reader[0];
                vrsta.Naziv = (string)reader[1];

                vrsteJela.Add(vrsta);
            }
            return vrsteJela;
        }

        public override string ToString()
        {
            return Naziv;
        }


    }
}
