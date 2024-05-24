using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations 
{
    public class SOVratiRecepte : SystemOperationBase
    {
        public List<Recept> recepti { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            recepti = repository.GetAll(new Recept()).OfType<Recept>().ToList();
            
            foreach(Recept recept in recepti)
            {
                List<StavkaRecepta> lista = repository.Search(new StavkaRecepta(), $"StavkeRecepta.ReceptID = {recept.ReceptID}").Cast<StavkaRecepta>().ToList();

                recept.StavkeRecepta = lista;
            }

        }
    }
}
