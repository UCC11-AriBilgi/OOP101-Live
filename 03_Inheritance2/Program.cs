using _03_Inheritance2;

internal class Program
{
    private static void Main(string[] args)
    {
        // Bir nesne oluşturalım

        Cat cat = new Cat();

        cat.FootCount = 4;
        cat.Age= 5;
        cat.BirthDate = new DateTime(2019, 3, 3);
        cat.Weight= 5;

        int _calCat;
        int _resultCat= cat.Run(20,1000,out _calCat);
        TimeSpan _restTimeCat= cat.Rest(DateTime.Now,DateTime.Now.AddDays(20));

        cat.CatHouse = "Büyük kedi evi";
        double _catHousePrice = cat.CatHousePrice(HouseType.big);

        List<HealthCare> _healthCareList= new List<HealthCare>();

        for (int i = 0; i <= 100 ; i=i+15)
        {
            HealthCare _healtCare = new HealthCare();

            _healtCare.Date = DateTime.Today.AddDays(-180).AddDays(i);
            _healtCare.Notes = $"Date : {_healtCare.Date.ToString("yyyy-MM-dd")} - " + $"{i.ToString()}";

            _healthCareList.Add( _healtCare );

        }

        cat.HealthCareHistory= _healthCareList;
        Console.WriteLine("--- Cat sınıfı bilgileri ---");
        Console.WriteLine(cat.AnimalInfo);
        Console.WriteLine(cat.CatHouse);
        Console.WriteLine(_catHousePrice.ToString());






        Console.ReadKey();
    }
}