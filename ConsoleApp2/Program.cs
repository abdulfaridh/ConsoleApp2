// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All arithmetic operations:");
            int num_1 = 10;
            int num_2 = 20;
            Console.WriteLine(num_1+num_2); // addition
            Console.WriteLine(num_1-num_2); //subraction
            Console.WriteLine(num_1*num_2); //multiplication
            Console.WriteLine((float)num_1/(float)num_2); //division
        }
    }
}