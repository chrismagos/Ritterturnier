using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritterturnier
{
    class Waffe
    {
        private string _bezeichnung;
        private Waffenart _art;
        public Waffe(string bezeichnung, Waffenart art)
        {
            _bezeichnung = bezeichnung;
            _art = art;
        }
        public Waffenart getArt()
        {
            return _art;
        }
        public string toString()
        {
            return $"Bezeichnung: {_bezeichnung}\nArt: {_art}";
        }
    }
}
