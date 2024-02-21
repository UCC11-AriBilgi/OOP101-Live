using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Abstraction
{
    internal class EngineerManager : clsEmployeeBaseManager
    {
        public EngineerManager() 
        {
            setTitle("Mühendis");
        }

        public override void doRaise()
        {
            double salary = getSalary(); // maası öğrendim

            double raise = salary + 2500; // zam yapıldı

            setSalary(raise); // yeni maas bilgisi işlendi.
        }

        public override void doRaise(double prmRaiseRate)
        {
            double salary = getSalary();

            double raise = salary + (salary * prmRaiseRate) + (salary % 2);

            setSalary(raise);
        }
    }
}
