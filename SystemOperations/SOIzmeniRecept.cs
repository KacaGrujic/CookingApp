using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class SOIzmeniRecept : SystemOperationBase
    {
        public Recept recept;
        protected override void ExecuteConcreteOperation()
        {
            repository.Update(recept, $" ReceptID = {recept.ReceptID}");

            foreach(StavkaRecepta stavka in recept.StavkeRecepta)
            {
                if(stavka.CrudStatus == Common.CrudStatus.Create)
                {
                    stavka.ReceptID = recept.ReceptID;
                    repository.Add(stavka);
                }
                else if(stavka.CrudStatus == Common.CrudStatus.Update)
                {
                    repository.Update(stavka, $" StavkeReceptaID = {stavka.StavkeReceptaID}");
                }
                else if (stavka.CrudStatus == Common.CrudStatus.Delete)
                {
                    repository.Delete(stavka, $" StavkeReceptaID = {stavka.StavkeReceptaID} AND ReceptID = {recept.ReceptID}");
                }
            }

            foreach(ProfilIshrane profil in recept.profili)
            {
                if(profil.CrudStatus == Common.CrudStatus.Update)
                {
                    repository.Update(profil, $" ReceptID = {profil.ReceptID}");
                }
            }

        }
    }
}
