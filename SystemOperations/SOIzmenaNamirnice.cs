using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class SOIzmenaNamirnice : SystemOperationBase
    {
        public Namirnica nam;
        protected override void ExecuteConcreteOperation()
        {
            repository.Update(nam, $" namirnicaID = {nam.NamirnicaID}");
        }
    }
}
