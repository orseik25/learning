using System;

namespace Bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            int j=1;
            int f=0;
            int dlinna=0;
            Console.WriteLine("Введите длинну массива:");
            dlinna=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите элементы массива:");
            int[] massive = new int [dlinna];
            while (f!=dlinna)
            {
                massive[f++]=Convert.ToInt32(Console.ReadLine());
            }
            while(i!=massive.Length){
                j=i+1;
                while(j!=massive.Length){
                                if (massive[j]>massive[i])
                                                {
                                                    //Console.WriteLine("n1={0}",massive[j]);
                                                    //Console.WriteLine("n={0}",massive[i]);
                                                    massive[j]=massive[i]+massive[j];//Сначала напишем алгоритм замены так как он сейчас на доске
                                                    massive[i]=massive[j]+massive[i];
                                                    massive[j]=massive[i]-massive[j];
                                                    massive[i]=massive[i]-(massive[j]*2);
                                                    j=i+1;
                                                }
                                            j++;
                                        }
                        i++;
                    }
                Console.WriteLine("Отсортированнный массив:");
                foreach(int p in massive)
                {
                    Console.WriteLine(p);
                }
            //Console.WriteLine("Hello World!"); 
        }
    }
}
