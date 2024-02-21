using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Abstraction
{
    // İşletme içersinde beden işçisi statüsünde çalışanlar için bir sınıf. Kendini EmployeeBaseManager den kalıtacak

    internal class clsEmployeeManager : clsEmployeeBaseManager
    {

        public clsEmployeeManager()
        {
            //Bu class ilk ayağa kalktığında en düşük title belirlesin

            setTitle("Beden İşçisi");

        }


        public override void doRaise() // çalışana düz zam yapacak kısım
        {
            double salary=getSalary(); // maası öğrendim

            double raise = salary + 500; // zam yapıldı

            setSalary(raise); // yeni maas bilgisi işlendi.
        }

        public override void doRaise(double prmRaiseRate) // primli zam kısmı
        {
            double salary = getSalary();

            double raise = salary + (salary * prmRaiseRate);

            setSalary(raise);
        }
    }
}
