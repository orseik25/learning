using System;

namespace Bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            int j=1;
            int[] massive = new int [6] {2,1,4,2,445,1};
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
            foreach(int vivod in massive)
            {
                Console.WriteLine(vivod);
            }
            //Console.WriteLine("Hello World!"); 
        }
    }
}
