using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class SOOBrisiRecept : SystemOperationBase
    {
        public Recept recept;
        protected override void ExecuteConcreteOperation()
        {
            repository.Delete(recept, $" Recept.ReceptID = '{recept.ReceptID}'");
            foreach(StavkaRecepta stavka in recept.StavkeRecepta)
            {
                repository.Delete(stavka, $" StavkeRecepta.ReceptID = '{recept.ReceptID}' ");
            }

        }
    }
}
