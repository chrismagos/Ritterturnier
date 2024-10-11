using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritterturnier
{
    class Teilnehmer
    {
        protected string _name;
        protected string _telefonnummer;
        protected int _id;
        protected int _idIncrement = 1;
        public Teilnehmer(string name, string telefonnummer) {
            _name = name;
            _telefonnummer = telefonnummer;
            _id = _idIncrement++;
        }
        public string GetName()
        {
            return _name;
        }
        public string toString()
        {
            return $"ID: {_id}\nName: {_name}\nTelefonnummer: {_telefonnummer}\n";
        }
    }
}
