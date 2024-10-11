using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritterturnier
{
    class NameSchonVorhandenException : Exception
    {
        public NameSchonVorhandenException(string message) : base(message) { }
    }
}
