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
    public class Recept : IEntity
    {
        [Browsable(false)]
        public int ReceptID { get; set; }
        [DisplayName("Recept")]
        public string Naziv { get; set; }
        [Browsable(false)]
        public string Opis { get; set; }
        [DisplayName("Vreme kuvanja")]
        public int VremeKuvanja { get; set; }
        [DisplayName("Tezina")]
        public string Tezina { get; set; }
        [DisplayName("Jelo")]
        public Jelo Jelo { get; set; }
        [Browsable(false)]
        public int UkupneKalorije { get; set; }
        [DisplayName("Kreator")]
        public Korisnik Korisnik { get; set; }
        [Browsable(false)]
        public ProfilIshrane ProfilIshrane { get; set; }
        [Browsable(false)]
        public List<ProfilIshrane> profili { get; set; }
        [Browsable(false)]
        public List<StavkaRecepta> StavkeRecepta { get; set; }
        [Browsable(false)]
        public StavkaRecepta StavkaRecepta { get; set; }
        [Browsable(false)]
        public List<string> ListaAlergena { get; set; }
        [Browsable(false)]
        public string TableName { get => "Recept"; }
        [Browsable(false)]
        public string InsertValues => $"('{Naziv}', '{Opis}', {VremeKuvanja}, {Jelo.JeloID}, {Korisnik.KorisnikID}, '{Tezina}', {UkupneKalorije})";
        [Browsable(false)]
        public string UpdateValues => $" Naziv = '{Naziv}', Opis = '{Opis}', VremeKuvanja = {VremeKuvanja}, JeloID = {Jelo.JeloID}, Tezina = '{Tezina}', UkupneKalorije = {UkupneKalorije}";
        [Browsable(false)]
        public string Join => " join Korisnik k on k.KorisnikID = Recept.KorisnikID join Jelo j on j.JeloID = Recept.JeloID join VrstaJela vj on vj.vrstaJelaID = j.vrstaJela join ProfilIshrane p on p.receptID = Recept.receptID";
        [Browsable(false)]
        public string Output => "inserted.ReceptID";
        [Browsable(false)]
        public List<IEntity> GetList(SqlDataReader reader)
        {
            try
            {
                List<IEntity> recepti = new List<IEntity>();
                while (reader.Read())
                {
                    Recept r = new Recept();
                    r.ReceptID = reader.GetInt32(0);
                    r.Naziv = reader.GetString(1);
                    r.Opis = reader.GetString(2);
                    r.VremeKuvanja = reader.GetInt32(3);
                    r.Tezina = reader.GetString(6);
                    r.UkupneKalorije = reader.GetInt32(7);
                    r.Jelo = new Jelo
                    {
                        JeloID = reader.GetInt32(12),
                        Naziv = reader.GetString(13),
                        VrstaJela = new VrstaJela
                        {
                            VrstaJelaID = reader.GetInt32(14),
                            Naziv = reader.GetString(17)
                        },
                        Kuhinja = reader.GetString(15)
                    };
                    r.Korisnik = new Korisnik
                    {
                        KorisnikID = reader.GetInt32(8),
                        ImePrezime = reader.GetString(9),
                        Username = reader.GetString(10),
                        Password = reader.GetString(11)
                    };
                    r.ProfilIshrane = new ProfilIshrane
                    {
                        ReceptID = reader.GetInt32(18),
                        VrstaJelaID = reader.GetInt32(19),
                        Naziv = reader.GetString(20)
                    };
                    r.profili.Add(r.ProfilIshrane);

                    recepti.Add(r);

                }
                return recepti;
            }
            catch (Exception ex)
            {
                reader.Close();
                throw ex;
            }
        }
        public Recept()
        {
            profili = new List<ProfilIshrane>();
        }

        [Browsable(false)]
        public CrudStatus CrudStatus { get; set; }
        [Browsable(false)]
        public string SearchQuery { get; set; }

        // public list stavke recepata
        //profil ishrane
        //lista alergena

    }
}
