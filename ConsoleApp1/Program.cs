namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        string line = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(line)) {

            if (string.IsNullOrWhiteSpace(line)) {
                Console.WriteLine("[BŁĄD] Wprowadzono puste dane! Musisz podać chociaż jedną liczbę!");
            }

        }
        
        int[] numbers = line.Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        
        Console.WriteLine("Liczba wprowadzonych elementow: " + numbers.Length);

        double average = calculateAvaerage(numbers);
        Console.WriteLine("Średnia: " + average);
        
        int max = CalculateMax(numbers);
        Console.WriteLine("Maksymalna wartość: " + max);        
        
        int min = CalculateMin(numbers);
        Console.WriteLine("Minimalna wartość:" + min);
        
    }

    static double calculateAvaerage(int[] nums)
    {
        if(nums.Length == 0) return 0;
        return nums.Average();
    }

    static int CalculateMax(int[] nums)
    {
        if(nums.Length == 0) return 0;
        return nums.Max();
    }

    static int CalculateMin(int[] nums)
    {
        if (nums.Length == 0) return 0;
        return nums.Min();
    }

}
