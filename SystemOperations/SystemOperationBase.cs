using Common;
using Repository.Implementation;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;



namespace SystemOperations
{
    public abstract class SystemOperationBase
    {
        protected IDBRepository<IEntity> repository;

        public SystemOperationBase()
        {
            repository = new GenericDBRepository();
        }

        public void Execute()
        {
            try
            {
                ExecuteConcreteOperation();
                repository.Commit();
            }
            catch (Exception ex)
            {

                repository.Rollback();
                throw ex;
            }
            finally
            {
                repository.Close();
            }
        }

        protected abstract void ExecuteConcreteOperation();

    }

}
