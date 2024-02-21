using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Inheritance
{
    internal class clsJob
    {
        public string jobName { get; set; }

        public void Work(clsWorker clsWorker)
        {
            Console.WriteLine($"{clsWorker.Ad} isimli çalışan {jobName} de çalışıyor...\n\n");
        }


        public void RaporAl(clsPerson clsPerson)
        {
            Console.WriteLine($"{clsPerson.Ad} isimli kişi sağlık raporunu aldı...\n\n");
        }
    }
}
  