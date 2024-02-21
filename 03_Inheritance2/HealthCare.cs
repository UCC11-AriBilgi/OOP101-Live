using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Inheritance2
{
    internal class HealthCare
    {
        public HealthCare()
        {
            Console.WriteLine("Sağlık bilgilerinin bulunduğu sınıf...");
        }

        private DateTime _date;
        private string _notes;

        public DateTime Date { get { return _date; } set { _date = value; } }

        public string Notes { get { return _notes;} set { _notes = value; } } 

    }
}
