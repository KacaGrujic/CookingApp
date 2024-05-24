using Common;
using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class SOLogin : SystemOperationBase
    {
        public Korisnik Korisnik { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            Korisnik k = (Korisnik)repository.Get(Korisnik, $"username = '{Korisnik.Username}' and password = '{Korisnik.Password}'");
            Korisnik = k;
        }
    }
}
