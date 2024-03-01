namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            //prompting for rows and it's width
            Console.Write("enter number of rows: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the row width: ");
            int y = int.Parse(Console.ReadLine());

            //setting up the loop and printing the block
            for (int rows = 0; rows < x; rows++)
            {
                for (int width = 0; width < y; width++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            {
                //Problem 2
                //prompting the number of rows
                Console.Write("whats the row width?: ");
                int z = int.Parse(Console.ReadLine());

                //setting up the loop and trying to make it work >:[
                for (int rowWidth = 0; rowWidth < z; rowWidth--)
                {
                    for (int rowLength = 0; rowLength <= z; rowLength--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                
            }

        }

           
            


        
    }
}