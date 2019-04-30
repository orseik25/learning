using System;

namespace insertionshort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 6, 8, 4, 2 };// Хочу еще добавить сюда ввод с клавы через пробел
            for (int i = 2; i <= (arr.Length-1); i++)//Ебаная сука Вес масива это колл во элементов, а не максимальный индекс сцуко бля!!!!!!
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[i]<=arr[j])
                    {
                        if (j==0)
                        {
                            Zam(i, j, ref arr);
                            break;
                           
                        }
                        if (arr[i] > arr[j - 1])
                        {
                            Zam(i, j, ref arr);
                            break;
                        }

                    }
                    else
                    {
                        break;
                    }
                }               
            }
            foreach(int y in arr)
            {
                Console.WriteLine(y);
            }
             
        }
        static int[] Zam(int i, int j, ref int[] arr)
        {
            int vstav = arr[i];
            int k = i - 1;
            while (k >= j)
            {
                arr[k + 1] = arr[k];
                k--;
            }
            arr[j] = vstav;
            vstav = 0;
            return arr;
        }
    }
    
}

