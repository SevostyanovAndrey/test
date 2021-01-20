using System;

namespace ProjectTest
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите в");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Большим числом является: "+a);
            
            }
            else {
                if(a == b)
                {
                    Console.WriteLine("Эти числа равны");
                        }
                else
                {
                    Console.WriteLine("Большим числом является: " + b);
                }
                
            }
            
        
            Console.ReadKey();
        }
    }
}
