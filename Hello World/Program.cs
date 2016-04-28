using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            string myValue = "Hello World";
            string anotherVariable = "Hello Again";

            int number1 = 5;
            int number2 = 5;

            string answer = number1.ToString() + number2.ToString();

            Console.WriteLine(answer);

            bool boolVar = false;
                        
            //Console.WriteLine(myValue);
            //Console.WriteLine(anotherVariable);
            //anotherVariable = myValue;
            //Console.WriteLine(anotherVariable);
        }
    }
}
