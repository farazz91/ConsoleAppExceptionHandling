using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptionHandling
{
    [Serializable]
    class UserLogInException : Exception
    {
        public UserLogInException() : base()
        {
            Console.WriteLine();
            Console.WriteLine("User login exception.");
        }
        public UserLogInException(string msg) : base(msg)
        {
            Console.WriteLine();
            Console.WriteLine("User login exception with message.");
        }
        public UserLogInException(string msg, Exception innerException) : base(msg, innerException)
        {
            Console.WriteLine();
            Console.WriteLine("User login exception with message and innerException.");
        }
        public UserLogInException(SerializationInfo info,StreamingContext context) : base(info, context)
        {
            Console.WriteLine();
            Console.WriteLine("User login exception with serrialization data.");
        }
    }
}
