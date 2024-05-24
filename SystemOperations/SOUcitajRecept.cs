using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class SOUcitajRecept : SystemOperationBase
    {
        public Recept recept;
        protected override void ExecuteConcreteOperation()
        {
            recept = (Recept)repository.Get(new Recept(), $"Recept.ReceptID ='{recept.ReceptID}'");

            List<StavkaRecepta> lista = repository.Search(new StavkaRecepta(), $"StavkeRecepta.ReceptID = {recept.ReceptID}").Cast<StavkaRecepta>().ToList();

            recept.StavkeRecepta = lista;
        }
    }
}
