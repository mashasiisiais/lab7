using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace laba04
{
    public class Abonent: IComparable
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string Info ()
        {
            return $"{Name}, {Number}, {Service}, {Extra}, {CostT}, {Debt}, {Contract}";
        }
        public int CompareTo (object obj)
        {
            Abonent t = obj as Abonent;
            return string.Compare(this.Name, t.Name);
        }
        public double Service { get; set; }
        public double Extra { get; set; }
        public double CostT { get; set; }
        
        public bool Debt { get; set; }
        public bool Contract { get; set; }
        public double YearIncome()
        {

            return (Service * CostT) + Extra;
        }
        public Abonent()
        { 
        }
        public Abonent(string name, string number, 
                 double service, double extra, double costT, bool debt, bool contract)
        {
            Name = name;
            Number = number;
            Debt = debt;
            Contract = contract;
            Service = service;
            Extra = extra;
            CostT = costT;

        }
    }
   
}
