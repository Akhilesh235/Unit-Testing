using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Testing
{
    class Program
    {
        public static int addResult, subResult, mulResult, divResult;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first intger : ");
            string integer1 = Console.ReadLine();
            Console.WriteLine("Enter the second intger : ");
            string integer2 = Console.ReadLine();

            int a = int.Parse(integer1);
            int b = int.Parse(integer2);
            Calculator calc = new Calculator();

            Console.WriteLine("Add : " + calc.Add(a, b));
            Console.WriteLine("Subtract: " + calc.Sub(a, b));
            Console.WriteLine("Multiply : " + calc.Multiply(a, b));           
            Console.WriteLine("Divide : " + calc.Divide(a, b));
            
            Console.ReadLine();



            //addResult = calc.Add(a, b);
            //Console.WriteLine("Add : " + addResult);

            //subResult = calc.Sub(a, b);
            //Console.WriteLine("Sub : " + subResult);

            //mulResult = calc.Sub(a, b);
            //Console.WriteLine("Add : " + mulResult); 

            //divResult = calc.Divide(a, b);
            //Console.WriteLine("Divide : " + divResult);



        }
    }
}
