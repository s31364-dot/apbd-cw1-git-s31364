using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        string line = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(line)) {
            Console.WriteLine(" BLĄD: Wejscie nie może byc puste");
        }
        
        int[] numbers = line.Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        
        Console.WriteLine("Liczba wprowadzonych elementow: " + numbers.Length);

        double average = calculateAvaeage(numbers);
        Console.WriteLine("Średnia: " + average);
    }

    static double calculateAvaeage(int[] nums)
    {
        if(nums.Length == 0) return 0;
        return nums.Average();
    }

}
