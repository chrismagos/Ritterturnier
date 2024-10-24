using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritterturnier
{
    public class Ritter : Teilnehmer
    {
        public string _rufname { get; set; }
        public Knappe _knappe { get; set; }
        public Waffe _waffe { get; set; }
        public int _id { get; set; }
        public static int _idIncrement = 1;
        public Ritter(string name, string telefonnummer, string rufname) : base(name, telefonnummer)
        {
            _rufname = rufname;
            _knappe = null;
            _waffe = null;
            _id = _idIncrement;
            _idIncrement++;
        }
        public Ritter(string name, string telefonnummer, string rufname, Knappe knappe, Waffe waffe) : base(name, telefonnummer)
        {
            _rufname = rufname;
            _knappe = null;
            _waffe = null;
            _knappe = knappe;
            _waffe = waffe;
            _id = _idIncrement;
            _idIncrement++;
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
            string s = this.GetType().Name + " " + _id + "\t" + base.toString() + $"Rufname: {_rufname}\n";
            if (_waffe != null)
            {
                s += $"\t\t{_waffe.toString()}";
            }
            if (_knappe != null)
            {
                s += $"\t\t{_knappe.toString()}";
            }
            return s;
        }
    }
}