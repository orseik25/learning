using System;

namespace Bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0;
            int n1=0; //Костыль пока тут нет кортежа
            int s=0;
            int i=0;

            while (s=i)
            {
                if (n1>n)
                {
                    s++;
                }
                    else
                    {
                    n1=n+n1;//Сначала напишем алгоритм замены так как он сейчас на доске
                    n=n1+n;
                    n1=n1-n;
                    n=n-(n1*2);
                    }
            }
            
            
            
            
            Console.WriteLine("Hello World!"); 
        }
    }
}
