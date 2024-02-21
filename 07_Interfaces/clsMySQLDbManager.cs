using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Interfaces
{
    internal class clsMySQLDbManager : IDatabase
    {
        private string value; // db deki bir değer
        private string username = "mysql";
        private string password = "admin";


        public void addvalue(string value)
        {
            this.value = value;
        }

        public void close()
        {
            Console.WriteLine("MySQLDB bağlantısı basarılı olarak kapandı...\n\n");
        }

        public void deletevalue()
        {
            this.value = null;

            Console.WriteLine("-> Veritabanındaki bilgi silindi...");

        }

        public void getvalue()
        {
            if (value != null)
            {
                Console.WriteLine($"İstediğiniz bilgi {value} ...basarılı sekilde okundu...\n\n");
            }
            else
            {
                Console.WriteLine("Gösterilecek herhangi bilgi bulunamadı...\n\n");
            }
        }

        public int login(string username, string password)
        {
            if (username == this.username && password == this.password)
            {
                return 1;
            }
            else return 0;
        }

        public void updatevalue(string value)
        {
            this.value = value;

            Console.WriteLine("Bilgiler güncellendi..\n\n");
        }
    }
}
