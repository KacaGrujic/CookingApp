using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class SOPronadjiRecepte : SystemOperationBase
    {
        public Recept recept;
        public List<Recept> Result;
        protected override void ExecuteConcreteOperation()
        {
            Result = repository.Search(recept, recept.SearchQuery).Cast<Recept>().ToList();
        }
    }
}
