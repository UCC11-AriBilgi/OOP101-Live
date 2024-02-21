using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Abstraction
{
    internal abstract class clsEmployeeBaseManager
    {
        // Burası diğer ilgili sınıflara hizmet edecek sınıfım.
        // Çalışanlar için temel bilgiler bulunacak

        private string name, surname, title; // Özlük bilgileri
        private double salary; // Mass bilgisi
        private int annualLeave; // Yıllık izin bilgisi

        // Çalışan kişilerin bilgilerini yazdıracağımız metotlar

        public void getInfo()
        {
            if (annualLeave > 0) // izin hakkı varsa
            {
                Console.WriteLine($"Abstract Company Employee\n\nAd : {name}\nSoyad : {surname}\nÜnvan : {title}\nMaaş : {salary} PNG Kina\nYıllık izin : {annualLeave}\n");
            }
            else
            {
                Console.WriteLine("Böyle bir çalışan bulunamadı..");
            }
        }

        // Çalışan bilgilerini oluşturacak metot
        public void setInfo(string pName,string pSurname,double pSalary)
        {
            if (pName.Length >= 3 && pSurname.Length >=2)
            {
                if (pSalary >=8500)
                {
                    this.name = pName;
                    this.surname = pSurname;
                    this.salary = pSalary;

                    if (pSalary >= 8500 && pSalary <= 12000)
                    {
                        this.title = "Deneyimli";
                        this.annualLeave = 20;
                    }
                    else if (pSalary >= 12001 && pSalary <= 15000)
                    {
                        this.title = "Kıdemli";
                        this.annualLeave = 24;
                    }
                    else if (pSalary >= 15001)
                    {
                        this.title = "Uzman";
                        this.annualLeave = 30;
                    }
                    else
                        this.annualLeave = 14;
                }
                else
                {
                    Console.WriteLine("UYARI : Çalışanınıza en az 8500 PNG Kina vermeniz gerekmektedir. O yüzden çalışan kaydı oluşturulamadı..");
                }
            }
            else
            {
                Console.WriteLine("HATA : Verilen bilgiler kriterlere uymuyor. Kontrol ediniz...");
            }
        }

        public double getSalary()
        {
            return this.salary;
        }

        public void setSalary(double pSalary)
        {
            this.salary = pSalary;
        }

        // Ünvan bilgisi için
        public void setTitle(string pTitle)
        {
            this.title = pTitle;
        }

        // Her nesne için özel zam seçenekleri olabileciği için bunları abstract metot imzası olarak tanımlayıp ilgili yerlerde içeriklerini dolduracağız.
        public abstract void doRaise(); //düz standard zam
        public abstract void doRaise(double prmRaiseRate); // zam + prim



    }
}
