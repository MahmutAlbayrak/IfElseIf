internal class Program
{
    private static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;

        if(time>=6 && time<11)
            Console.WriteLine("Gunaydin");
        else if(time <= 18)
            Console.WriteLine("Iyi gunler");
        else
            Console.WriteLine("Iyi geceler");

        string sonuc = time <=18 ? "İyi gunler" : "İyi geceler";

        sonuc = time >=6 && time < 11 ? "Gunaydin" : time<= 18 ? "Iyi gunler" : "Iyı geceler";
        Console.WriteLine(sonuc); 
    }
}