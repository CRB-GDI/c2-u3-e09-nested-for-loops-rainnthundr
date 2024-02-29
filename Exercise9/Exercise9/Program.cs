namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problem 1

            Console.Write("enter number of rows: ");
            int row = int.Parse(Console.ReadLine());

            for (int i = 0; i < row; i++)
            {
                Console.WriteLine(row);
            }
          
            Console.WriteLine("enter the row width: ");
            int numberAsterisks = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberAsterisks; i++)
            {
                Console.Write("*");
            }

            //Problem 2

            Console.Write("enter the number of row width: ");
            int width = int.Parse(Console.ReadLine());
            
            for (int i = 0; i >= width; i++)
            {
                Console.Write("*");
            }
        }
            


        
    }
}