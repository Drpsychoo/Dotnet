using System;

namespace oddeven
{
    class oddeven
    {
        static void Main(string[] args)
        {

            int a, b, sum,c;
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter a first number :");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number :");
            b=int.Parse(Console.ReadLine());

            sum = a + b;
            if (sum % 2 == 0) {
                Console.WriteLine("sum of two number is even at first :" +sum );

                c = sum - 1;
                Console.WriteLine("changing into odd :" +c );

            }
            else
            {
                Console.WriteLine("sum of two number is odd at first :" + sum);

                c = sum + 1;
                Console.WriteLine("changing into even :" + c);


            }





        }
    }
}