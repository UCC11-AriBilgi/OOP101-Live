using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Abstraction
{
    // Abstract yapısını daha iyi kavrayabilmek için programı daha esnek hale getirmek için bu sınıf yaratıldı. Personel ekleme işlemlerimni yapacak.
    // Burası elemanı yoktan varedecek. Liste oluşturma gibi...

    internal class clsCreateEmployeeManager
    {
        public clsEmployeeBaseManager employeeBaseManager;

        private string name, surname;

        private double salary;

        // Çalışan yaratılıyor..
        public void Create()
        {
            Console.WriteLine("Çalışanın adı :");
            name = Console.ReadLine();

            Console.WriteLine("Çalışanın soyadı :");
            surname = Console.ReadLine();

            Console.WriteLine("Maaşı :");
            salary = Convert.ToInt32(Console.ReadLine());

            //employeeBaseManager= new clsEmployeeBaseManager();

            employeeBaseManager.setInfo(name,surname,salary);
        }

        public void getInfo()
        {
            employeeBaseManager.getInfo();
        }

        public void doRaise()
        {
            employeeBaseManager.doRaise(); // Normal çalışan için zam metodu çağrılıyor
        }

        public void doRaise(double pRaiseRate)
        {
            employeeBaseManager.doRaise(pRaiseRate);

            Console.WriteLine($"Primli zam uygulandı\n\nYeni Maaş : {employeeBaseManager.getSalary()} PNG Kina olmuştur..");
        }


    }
}
