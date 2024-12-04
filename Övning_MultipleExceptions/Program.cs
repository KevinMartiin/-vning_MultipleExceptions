namespace Övning_MultipleExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Testfall
            HandleMultipleExceptions("2", 1); 
            HandleMultipleExceptions("abc", 1);
            HandleMultipleExceptions("2", 5);
        }

        static void HandleMultipleExceptions(string inputString, int index)
        {
            
            int[] numbers = { 1, 2, 3 };

            try
            {
                
                int parsedNumber = int.Parse(inputString);

                Console.WriteLine(numbers[index]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range.");
            }
        }
    }
}
