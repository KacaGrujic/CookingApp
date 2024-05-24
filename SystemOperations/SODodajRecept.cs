using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class SODodajRecept : SystemOperationBase
    {
        public Recept recept;
        public ProfilIshrane profil;
        protected override void ExecuteConcreteOperation()
        {
            int receptID = int.Parse(repository.Add(recept).ToString());
            recept.ReceptID = receptID;
            if (recept.ReceptID == 0) throw new Exception("Greska u dodavanju recepta");
            foreach(StavkaRecepta stavka in recept.StavkeRecepta)
            {
                recept.StavkaRecepta = stavka;
                stavka.ReceptID = receptID;
                repository.Add(stavka);
            }

            foreach(ProfilIshrane pi in recept.profili)
            {
                pi.ReceptID = receptID;
                repository.Add(pi);
            }

            //profil.ReceptID = receptID;
            //profil.VrstaJela.VrstaJelaID = recept.Jelo.VrstaJela.VrstaJelaID;
            //repository.Add(profil);

        }
    }
}
