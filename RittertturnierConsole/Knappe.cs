using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritterturnier
{
    public class Knappe : Teilnehmer
    {
        public int _ausbildungsgrad { get; set; }
        public Knappe(string name, string telefonnummer, int ausbildungsgrad) : base(name, telefonnummer)
        {
            _ausbildungsgrad = ausbildungsgrad;
        }
        public string toString()
        {
            return $"Knappe: {_name}\tAusbildungsgrad: {_ausbildungsgrad}";
        }
    }
}
