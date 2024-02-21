using _07_Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        int option;

        clsDbManager database;

        ///---> Sorgulama İşlemleri
        ///
        Console.WriteLine("< Veritabanı Bağlantıları >\n");
        Console.WriteLine("[1] - Oracle Database Bağlantısı Kur");
        Console.WriteLine("[2] - Mysql Database Bağlantısı Kur");
        Console.WriteLine("[3] - MongoDb Bağlantısı Kur\n");
        Console.Write("-> Seçiminiz : ");

        option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                database = new clsDbManager(new clsOracleDbManager());
                database.loginDB();
                break;
            case 2:
                database = new clsDbManager(new clsMySQLDbManager());
                database.loginDB();
                break;
            case 3:
                database = new clsDbManager(new clsMongoDbManager());
                database.loginDB();
                break;
            default:
                break;
        }
    }
}