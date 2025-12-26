using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class DNINoValidoException:ApplicationException
    {
        public DNINoValidoException():base() { }
        public DNINoValidoException(string message):base(message) { }
        public DNINoValidoException(string message,Exception inner):base(message,inner) { }
    }
}
