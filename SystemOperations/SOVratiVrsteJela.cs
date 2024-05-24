using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class SOVratiVrsteJela : SystemOperationBase
    {
        public List<VrstaJela> vrsteJela { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            vrsteJela = repository.GetAll(new VrstaJela()).OfType<VrstaJela>().ToList();
        }
    }
}
