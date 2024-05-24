using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class SONadjiJela : SystemOperationBase
    {
        public Jelo jelo;
        public List<Jelo> Result;
        protected override void ExecuteConcreteOperation()
        {
            Result = repository.Search(jelo, jelo.SearchQuery).Cast<Jelo>().ToList();
        }
    }
}
