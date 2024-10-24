using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritterturnier
{
    public class Waffe
    {
        public string _bezeichnung { get; set; }
        public Waffenart _art { get; set; }
        public Waffe(string bezeichnung, Waffenart art)
        {
            _bezeichnung = bezeichnung;
            _art = art;
        }
        public string toString()
        {
            return $"Waffe: {_bezeichnung}\tArt: {_art}\n";
        }
    }
}
