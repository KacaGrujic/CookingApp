using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class SOUcitajJelo : SystemOperationBase
    {
        public Jelo jelo;
        protected override void ExecuteConcreteOperation()
        {
            jelo = (Jelo)repository.Get(new Jelo(), $"JeloID = '{jelo.JeloID}'");
        }
    }
}
