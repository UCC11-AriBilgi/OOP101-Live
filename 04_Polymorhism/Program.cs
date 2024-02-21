using _04_Polymorhism;

internal class Program
{
    private static void Main(string[] args)
    {
        clsTutorials clsTutorials= new clsTutorials();

        clsTutorials.setTutorial(1, "C# dersleri"); // 1.hali
        Console.WriteLine(clsTutorials.getTutorial());

        clsTutorials.setTutorial("SQL Server Dersleri");
        Console.WriteLine(clsTutorials.getTutorial());

        clsTutorials.setTutorial(3, "HTML Dersleri", "İçerik web");
        Console.WriteLine(clsTutorials.getTutorial());


        

        Console.ReadKey();
    }
}