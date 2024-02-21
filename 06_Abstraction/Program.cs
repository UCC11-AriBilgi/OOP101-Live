using _06_Abstraction;

internal class Program
{
    // Bir işletme ve çalışanlar üzerinde bir örnek

    private static void Main(string[] args)
    {
        // Öncelikle bir beden işçisi tanımlayalım...

        clsCreateEmployeeManager bodyworker= new clsCreateEmployeeManager(); // bodyworker nesnesi yaratıldı.

        bodyworker.employeeBaseManager = new clsEmployeeManager();

        bodyworker.Create();

        bodyworker.getInfo();

        // bir mühendis yaratalım

        clsCreateEmployeeManager engineer = new clsCreateEmployeeManager(); // engineer nesnesi yaratıldı.

        engineer.employeeBaseManager = new EngineerManager(); // mühendisler için 

        engineer.Create();

        engineer.getInfo();

        Console.ReadKey();



    }
}