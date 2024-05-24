using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class SOVratiJela : SystemOperationBase
    {
        public List<Jelo> Jela { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            Jela = repository.GetAll(new Jelo()).OfType<Jelo>().ToList();
        }
    }
}
