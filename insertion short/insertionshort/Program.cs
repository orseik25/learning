using System;

namespace insertionshort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 6, 8, 4, 2 };// Хочу еще добавить сюда ввод с клавы через пробелы
            int j = 0;
            int VstavkaVRazriv = 0;
            int MestoRazriva = 0;
            foreach (int i in arr)
            {
                for(j = i - 1;j = !0; j--)
                {
                    if (arr[j] >= arr[i])
                    {
                        if (arr[j - 1] >= arr[i])
                        {

                        }
                        else
                        {
                            VstavkaVRazriv = i;
                            MestoRazriva = j;
                            //Здесь должен быть переход в класс премещение с передачей массива разрыва и вставляемого элемента
                        }
                    }
                }
            }
        }//Сюда надо будет добавить вывод массива
    }
}
