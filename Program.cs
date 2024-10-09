using System.Runtime.CompilerServices;

namespace T6_random_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random generator  = new Random();
            //int randNum;
            //randNum = generator.Next(10);
           

            //Console.WriteLine("My randum number is " + randNum);
            Random generator = new Random();
            int num1 = generator.Next(2);
            int num2 = generator.Next(2);
            Console.WriteLine(num2);
            if (num1 == num2)
            {
                Console.WriteLine("Hey! the numbers are the same thats rare.");
            }
            else
            {
                Console.WriteLine("Hey, the numbers are different. Thats normal.");
            }




        }
    }    
    



 

}
