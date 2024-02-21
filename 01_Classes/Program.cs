using _01_Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        // Tanımlanmış bir sınıftan nesne yaratılması
        #region Sınıf--> Nesne
        //clsCustomerManager customerManager = new clsCustomerManager(); // nesne oluşturuluyor
        //customerManager.Add(); // ilgili sınıftaki bir metodu kullanıyorum

        //clsProductManager productManager = new clsProductManager();
        //productManager.Add();

        //customerManager.Remove();

        //productManager.Remove();


        #endregion

        #region Sınıf-->Nesne, prop kullanımı
        // 1.Yol
        clsCustomer customer = new clsCustomer();

        customer.Id = 1;
        customer.FirstName = "Ümit";
        customer.LastName = "KARAÇİVİ";
        customer.City = "İstanbul";

        // 2.Yol
        clsCustomer customer1 = new clsCustomer
        {
            Id = 2,
            FirstName = "Nurgül",
            LastName = "KARAÇİVİ",
            City = "Bursa"
        };

        clsCustomer customer2 = new clsCustomer();

        customer2.FirstName = "Doğa Bengi"; // class tarafında set metodu kullanılıyor

        // burada da class tarafında get metodu kullanılıyor.
        Console.WriteLine("Müşteri adı : " + customer.FirstName + "\n\n");
        Console.WriteLine("Müşteri adı : " + customer1.FirstName + "\n\n");
        Console.WriteLine("Müşteri adı : "+ customer2.FirstName + "\n\n");


        #endregion



        Console.ReadKey();
    }
}