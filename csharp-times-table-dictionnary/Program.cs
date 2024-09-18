namespace TimesTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> table = new Dictionary<int, int>();

            string input;

            Console.WriteLine("Write a number to multiply : ");
            input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            Console.WriteLine("Until what number do you want the multiplication :");
            input = Console.ReadLine();
            int secondNumber = Convert.ToInt32(input);

            table.Add(number, secondNumber);

            for(int i = 0; i < table.Count; i++)
            {
                var pair = table.ElementAt(i);
                for(int y = 0; y <= pair.Value; y++)
                {
                    Console.WriteLine($"{pair.Key} x {y} = {pair.Key * y}\n");
                }
            }
            
        }
    }
}