namespace Task_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Number of Small Carpet");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" {n}  ");
            Console.WriteLine(" Number of large Carpet");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" {n2}  ");
            Console.WriteLine(" Price for Small Carpet:25$ ");         
            Console.WriteLine(" Price for large Carpet:35$ ");
            Double cost = n * 25 + n2 * 35;
            Console.WriteLine($" cost={cost} ");
            Double Tax = cost*0.06;
            Console.WriteLine($" Tax = {Tax}");
            Console.WriteLine($" Total estimate:{cost+Tax} ");
            Console.WriteLine(" This estimate is valid for 30 Days ");
            
           
        }
    }
}
