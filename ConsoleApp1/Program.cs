namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        string line = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(line)) {
            Console.WriteLine(" BLĄD: Wejscie nie może byc puste");
            return;
        }

    }
}