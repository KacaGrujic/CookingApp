using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class SOUcitajNamirnicu : SystemOperationBase
    {
        public Namirnica nam;
        protected override void ExecuteConcreteOperation()
        {
            nam = (Namirnica)repository.Get(new Namirnica(), $"NamirnicaID = '{nam.NamirnicaID}'");
        }
    }
}
