internal class Program : StudentProtected // Program sınıfı StudentProtected sınıfından kalıtılıyor..miras alıyor
{
    private static void Main(string[] args)
    {
        // Public keyword

        //Student student = new Student(); // nesne oluştu

        //Console.WriteLine($"Bilgiler : \n\nID : {student.Id} \nAdı : {student.FirstName} \nSoyadı : {student.LastName} \n\n");

        //student.SayHello();


        // Private keyword
        //StudentPrivate studentPrivate = new StudentPrivate();


        //Console.WriteLine($"Bilgiler : \n\nID : {studentPrivate.Id} \nAdı : {studentPrivate.FirstName} \nSoyadı : {studentPrivate.LastName} \n\n");

        //studentPrivate.SayHello();

        // Protected keyword
        //StudentProtected studentProtected = new StudentProtected();
        Program program = new Program();

        Console.WriteLine($"Bilgiler : \n\nID : {program.Id} \nAdı : {program.FirstName} \nSoyadı : {program.LastName} \n\n");

        program.SayHello();

        Console.ReadKey();
    }
}

// public özelliklere sahip bir sınıf
class Student
{
    // prop code snippet

    // propertyleri public olarak tanımlandı

    public int Id=1;
    public string FirstName = "Ümit ";
    public string LastName = "KARAÇİVİ";

    public void SayHello()
    {
        Console.WriteLine("Public Student sınıfından sevgilerle...");
    }

}

// Private özelliklere sahip bir sınıf
class StudentPrivate
{
    private int Id = 1;
    private string FirstName = "Ümit ";
    private string LastName = "KARAÇİVİ";

    private void SayHello()
    {
        Console.WriteLine("Private Student sınıfından sevgilerle...");
    }
}

// Protected özelliklere sahip bir sınıf
class StudentProtected
{
    protected int Id = 1;
    protected string FirstName = "Ümit ";
    protected string LastName = "KARAÇİVİ";

    protected void SayHello()
    {
        Console.WriteLine("Protected Student sınıfından sevgilerle...");
    }

}