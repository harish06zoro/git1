using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git1
{
    class Program
    {
        static void Main(string[] args)
        {
            q2();

          
        }

        public static int getinteger(string message)
        {
            Console.WriteLine(message);
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        public static double getdouble(string information)
        {
            Console.WriteLine(information);
            double number = double.Parse(Console.ReadLine());
            return number;
        }
        public static void q1()
        {
            int firstvalue = getinteger("enter the first value");
            int secondvalue = getinteger("enter the second value");
            int addresult = addition(firstvalue, secondvalue);
            int diffresult = different(firstvalue, secondvalue);
            int prodresult = product(firstvalue, secondvalue);
            Console.WriteLine("the addition of two numbers:" + addresult);
            Console.WriteLine("the different of two numbers:" + diffresult);
            Console.WriteLine("the product of two number :" + prodresult);
        }
        public static int addition(int a,int b)
        {
            return   a + b;
        }
        public static int different(int a, int b)
        {
            return (Math.Abs(a - b));
        }
        public static int product(int a, int b)
        {
            return a * b;
        }

        public static void q2()
        {
            int firstvalue = getinteger("enter the first value");
            int secondvalue = getinteger("enter the second value");
            double result = powerinteger(firstvalue, secondvalue);
            Console.WriteLine(result);
        }
        public static double powerinteger(int a,int b)
    {

        return (Math.Pow(a, b));


    }

        
    }
}
