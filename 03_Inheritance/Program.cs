using _03_Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        clsTrainer trainer = new clsTrainer();

        trainer.Ad = "Ümit";
        trainer.Soyad = "KARAÇİVİ";
        trainer.Brans = "C#";
        trainer.Maas = 5000;


        clsSalesRepresant salesRepresant = new clsSalesRepresant();
        salesRepresant.Ad = "Ahmet";
        salesRepresant.Maas = 3000;

        clsStudent student = new clsStudent();
        student.Ad = "Arda";
        student.Okul = "İTÜ";

        clsJob job = new clsJob();

        job.jobName = "Kendine uygun bir işte ";

        job.Work(trainer);
        //job.Work(student); // student nesnesi Person sınıfından türediği için metoda gönderilemiyor.
        job.Work(salesRepresant);

        job.RaporAl(student);
        job.RaporAl(trainer);
        job.RaporAl(salesRepresant);
 


        Console.ReadKey();
    }
}