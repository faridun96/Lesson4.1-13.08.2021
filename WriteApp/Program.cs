using System;

namespace WriteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Прямоугольный треугольник");
             for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                     if(i==0 || j==0 || i==10-1 || j==10-1) 
                     Console.Write("*");                 
                     else Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            Console.WriteLine("Прямоугольник");
            int a=5;
            int b=20;
            for (int i = 0; i < a; i++) 
            {
            for (int j = 0; j < b; j++) 
            {
                if(i==0 || j==0 || i==a-1 || j==b-1) 
                 Console.Write("*");                 
                else Console.Write(" ");
            }
                Console.Write("\n");
            }  
                Console.Write("\n");
            Console.WriteLine("Равносторонний треугольник");
            int num = 10;
            for (int i = 1; i <= num; ++i){
            for (int j = num; j > i; --j)
                Console.Write(" ");
            for (int j = 1; j < 2 * i; ++j)
                if(i==0 || j==0 || i==num-0 || j==num-9) 
                Console.Write("*");                 
                else Console.Write(" ");
            for (int j = 1; j < 2 * i; ++j)
                if(i==1 || j==1 || i==i-1 || j==j-1) 
                Console.Write("*");                 
                else Console.Write(" ");
            Console.WriteLine();
            }
            Console.WriteLine("Ромб");
            for (int i = 1; i < num; ++i){
            for (int j = num; j > i; --j)
                Console.Write(" ");
            for (int j = 1; j < 2 * i; ++j)
                //Console.Write("*");
                if(i==0 || j==0 || i==i-1 || j==num-9) 
                Console.Write("*");                 
                else Console.Write(" ");
            for (int j = 1; j < 2 * i; ++j)
                if(i==1 || j==1 || i==i-1 || j==j-1) 
                Console.Write("*");                 
                else Console.Write(" ");
            Console.WriteLine();
            }
            for (int i = num; i >= 1; --i){
            for (int j = num; j > i; --j)
                Console.Write(" ");
            for (int j = 1; j < i*2; ++j)
                if(i==0 || j==0 || i==i-1 || j==num-9) 
                Console.Write("*");                 
                else Console.Write(" ");
            for (int j = 1; j < i*2; ++j)
                if(i==1 || j==1 || i==i-1 || j==j-1) 
                Console.Write("*");                 
                else Console.Write(" ");
            Console.WriteLine();
            }
        }
    }
}