using Common.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klijent.Communication
{
    public static class CommunicationUtil
    {

        public static T ParseResponse<T>(this Response response)
        {
            if (response.Exception == null)
            {
                return (T)response.Result;
            }
            else
            {
                throw response.Exception;
                Console.WriteLine("resp exc " + response.Exception.Message);
            }
        }
    }
}
