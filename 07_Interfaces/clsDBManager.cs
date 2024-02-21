using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Interfaces
{
    // Dblerimi yönetecek
    internal class clsDbManager
    {
        private IDatabase database; // Interfaceden bir değişgen tanımlıyorum.

        public clsDbManager() // Default Constructor
        {

        }

        public clsDbManager(IDatabase database) // Parametrik constructor.. Ben buraya o anki db classının kendisini göndercem
        {
            this.database = database; // O anki gelen db parametresine göre içsel değeri değiştiriyorum.

        }

        public void loginDB() // Sistem giriş
        {
            string userName, password;

            Console.WriteLine("< Veri Tabanı Bağlantısı >\n\n-> Kullanıcı Adı : ");
            userName = Console.ReadLine();

            Console.WriteLine("-> Kullanıcı Şifresi : ");
            password = Console.ReadLine();


            if (database.login(userName, password) == 1)
            {
                menu();

            }
            else
                Console.WriteLine("Bağlantı bilgilerinde bir terslik var...Kontrol rdiniz...\n");
        }

        public void closeDB()
        {
            database.close();
        }

        private void addValue(string value)
        {
            database.addvalue(value);

        }

        private void deleteValue()
        {
            database.deletevalue();


        }

        private void getValue()
        {
            database.getvalue();
        }

        private void menu()
        {
            string value;
            int v;
            Console.WriteLine("< Veri Tabanı İşlemleri >\n");
            Console.WriteLine("[1] - Veri Ekle\n[2] - Veri Sil\n[3] - Veri Getir\n[4] - Bağlantıyı Kes\n");
            Console.Write("-> Yapmak istediğiniz işlem: ");

            v = Convert.ToInt32(Console.ReadLine());
            switch (v)
            {
                case 1:
                    Console.Write("{0}\n-> Eklemek istediğiniz veri: ");
                    value = Console.ReadLine();

                    addValue(value);
                    Console.Clear();
                    menu();
                    break;
                case 2:
                    Console.Clear();
                    deleteValue();
                    menu();
                    break;
                case 3:
                    Console.Clear();
                    getValue();
                    menu();
                    break;
                case 4:
                    closeDB();
                    break;
            }
        }

    }
}