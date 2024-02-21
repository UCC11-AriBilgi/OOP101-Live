using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Interfaces
{
    internal interface IDatabase
    {
        // Buraya sadece metot(içeriksiz olarak)/property yapılarını tanımlıyoruz
        // Yani bir şablon tanımlıyoruz.

        int login(string username, string password); // db ye giriş yapan metot

        void close(); // dbyi kapatacak

        void addvalue(string value); // db ye değer ekliyor

        void deletevalue(); // db de değer siler

        void updatevalue(string value); // db de güncelleme yapar

        void getvalue(); // db den bir değer getirir
    }
}
