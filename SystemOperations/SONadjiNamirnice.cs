using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class SONadjiNamirnice : SystemOperationBase
    {
        public Namirnica namirnica;
        public List<Namirnica> Result;
        protected override void ExecuteConcreteOperation()
        {
            Result = repository.Search(namirnica, namirnica.SearchQuery).Cast<Namirnica>().ToList();
        }
    }
}
