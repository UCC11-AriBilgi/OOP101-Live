using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Inheritance
{
    internal class clsWorker : clsPerson // Kalıtım
    {
        public int Maas {  get; set; }

        public DateTime IseGirisTarihi { get; set; }
    }
}
