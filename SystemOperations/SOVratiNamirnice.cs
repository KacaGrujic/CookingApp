using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class SOVratiNamirnice : SystemOperationBase
    {
        public List<Namirnica> Namirnice { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            Namirnice = repository.GetAll(new Namirnica()).OfType<Namirnica>().ToList();
        }
    }
}
