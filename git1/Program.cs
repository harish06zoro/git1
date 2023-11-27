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
            q16();

          
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
        public static void q3()
        {
            double length = getdouble("enter the value for length");
            double width = getdouble("enter the value for width");
            double height = getdouble("enter the value for height");
            double result = volumeofrectangle(length, width, height);

            Console.WriteLine(" the volume of rectangle is:" +result);
        }
        public static double volumeofrectangle(double l, double w, double h)
        {
            return l * w * h;

        }
        public static void q4()
        {
            int radius = getinteger("enter the value radius");
            double result = perimeterofcircle(radius);
            Console.WriteLine(" perimeter of the circle:" + result);
        }
        public static double perimeterofcircle(int r)
        {
            double pi = Math.PI;
            return (2 * pi * r);
        }
        public static void q5()
        {
            int numerator = getinteger("enter the numerator value");
            int denominator = getinteger("enter the denominator value");
            int quotresult = quotient(numerator, denominator);
            int remairesult = remainder(numerator, denominator);
            Console.WriteLine("the quotient and the remainder is:{0}:{1}", quotresult, remairesult);
        }
        public static int quotient(int a, int b)
    {
        return a/b;
    }
        public static int remainder(int a, int b)
        {
            return a % b;
        }

        public static void q6()
        {
            int value = getinteger("enter the value to find the square value :");
            int result = squarevalue(value);
            Console.WriteLine("the square value of the given number is :" + result);
        }
        public static int squarevalue(int a)
        {
            return a * a;
        }

        public static void q7()
        {
            int value = getinteger("enter the value to find the square root  value:");
            double result = squarerootvalue(value);
            Console.WriteLine("the square root value of the given number is:" + result);
        }
        public static double squarerootvalue(int num)
        {
            return (Math.Sqrt(num));
        }
        public static void q8()
        {
            double bredth = getdouble("enter  the value of breath");
            double height = getdouble("enter the value for height");
            double result = areaoftriangle(bredth, height);
            Console.WriteLine("the area of the triangle is :" + result);
        }
        public static double areaoftriangle (double b,double h)
        {
            return(1/2.0*(b*h));
        }

        public static void q9()
        {
            int kilometer = getinteger("enter the kilometer to find the mile value:");
            double result = kilotomiles(kilometer);
            Console.WriteLine("the mile calculation  of the given number is:" + result);
        }
        public static double kilotomiles(int num)
        {
            double onemile = 1.60934;
            return (num * onemile);
        }
        public static void q10()
    {
        int celsius = getinteger("enter  the celsius:");
        double result =celsiustofahrenheit(celsius);
        Console.WriteLine(" the  fahrenheit of the given celsius is :" + result);

    }
    public static double celsiustofahrenheit (int celsius)
{
    return ((celsius *9/5.0)+32);
}
    public static void q11()
    {
        int firstvalue = getinteger("enter the value of first variable:");
        int secondvalue = getinteger("enter the value of second variable:");
        swaptwovalues(firstvalue, secondvalue);
    }
    public static void swaptwovalues(int a, int b)
    {
        int temp;
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("the value after swap");
        Console.WriteLine("value of first variable:" + a);
        Console.WriteLine(" value of  second variable:" + b);
       
    }
    public static void q12()
    {
        int firstvalue = getinteger("enter the value of first variable:");
        int secondvalue = getinteger("enter the value of second variable:");
        swaptwovalues(firstvalue, secondvalue);
    }
    public static void swapwithouttempvar(int a, int b)
    {
        a = a * b;
        b = a / b;
        a = a / b;
        Console.WriteLine("the value after swap");
        Console.WriteLine(" the value of the first variable:" + a);
        Console.WriteLine("the value of the second variable:" + b);
    }
    public static void q13()
    {
        int firstvalue = getinteger("enter the value of the first variable:");
        int secondvalue = getinteger("enter the value of the second variable:");
        swapwithoutcausingoverflow(firstvalue, secondvalue);
    }
    public static void swapwithoutcausingoverflow(int a, int b)
    {
        a = a ^ b;
        b = a ^ b;
        a = a ^ b;
        Console.WriteLine("the values after swap");
        Console.WriteLine(" the values of the first variable :" + a);
        Console.WriteLine(" the value of the second variable:" + b);
    }
        public static void q14()
        {
            int starting =getinteger(" enter the starting range for generating the random values:");
            int end = getinteger(" enter the ending range for generating the random values:");
            int result=randomvalues (starting,end);
            Console.WriteLine("the random value is :"+result);
        }
        public static int randomvalues(int a, int b)
        {
            Random r = new Random();
            int random = r.Next(a, b);
            return random;
        }

        public static void q15()
        {
            double length = getdouble("enter the length field ");
            double width = getdouble("enter the width field");
            double result = areaoffieldinacer(length, width);
            Console.WriteLine(result);
        }
        public static double areaoffieldinacer(double length, double width)
        {
            int oneacer = 43560;
            return (length * width / oneacer);
        }


        public static void q16()
        {
            int number = getinteger("enter the number");
            double result = sumnaturalnumbers(number);
            Console.WriteLine(result);
        }
        public static double sumnaturalnumbers(int num)
        {
            return (num * (num + 1) / 2);

        }
        public static void q17()
        {
            int mark1 = getinteger("enter the mark first subject:");

            int mark2 = getinteger("enter the mark second  subject:");
            int mark3 = getinteger("enter the mark third subject:");
            Console.WriteLine(average(mark1, mark2, mark3));
        }
        public static double average(int a, int b, int c)
        {
            double total = a + b + c;
            return (total / 3);
        }


        
    }
}
