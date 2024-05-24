﻿using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class SOIzmenaJela : SystemOperationBase
    {
        public Jelo jelo;
        protected override void ExecuteConcreteOperation()
        {
            repository.Update(jelo, $" jeloID = {jelo.JeloID}");
        }
    }
}
