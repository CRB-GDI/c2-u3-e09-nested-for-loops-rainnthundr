namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problem 1

            Console.Write("enter number of rows: ");
            int x = int.Parse(Console.ReadLine());
            
            Console.WriteLine("enter the row width: ");
            int y = int.Parse(Console.ReadLine());

            for (int rowsPrinted = 0; rowsPrinted < x; rowsPrinted++)
            {
                for (int width = 0; width < y; width++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }    

             
        }
            


        
    }
}