using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritterturnier
{
    class Ritter : Teilnehmer
    {
        private string _rufname;
        private Knappe _knappe;
        private Waffe _waffe;

        public Ritter(string name, string telefonnummer, string rufname) : base(name, telefonnummer)
        {
            _rufname = rufname;
            _knappe = null;
            _waffe = null;
        }
        public Waffe getWaffe()
        {
            return _waffe;
        }
        public void addKnappe(Knappe knappe)
        {
            _knappe = knappe;
        }
        public void addWaffe(Waffe waffe)
        {
            _waffe = waffe;
        }
        public string toString()
        {
            string s = base.toString();
            s += $"Rufname: {_rufname}\n";
            if (_knappe != null)
            {
                s += $"Knappe:\n{_knappe.toString()}";
            }
            if (_waffe != null)
            {
                s += $"Waffe:\n{_waffe.toString()}";
            }
            return s;
        }
    }
}