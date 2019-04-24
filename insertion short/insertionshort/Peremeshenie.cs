using System;

public class Peremeshenie
{
    public int[] Perem(int[] arr, ref int VstavkaVRazriv, ref int MestoRazriva)
	{
        //void Перемещение(/*Вход, arr[], VstavkaVRazriv, MestoRazriva, Выход, arr[]*/)
            // item 120
            /*arr[]
            VstavkaVRazriv
            MestoRazriva*/
            // item 100
            String newarr = null;
            for(int i=0;i<=arr.Length;i++)
            {
            // item 1030001
            if (i == MestoRazriva)
            {
                newarr += (Convert.ToString(arr[VstavkaVRazriv])) + " " + (Convert.ToString(arr[i]));
            } else {
                    if (i == VstavkaVRazriv) { }
                     else
                     {
                       newarr += (Convert.ToString(arr[i])) + " ";
                     }
                   }
            }
        Pererabotka Raz = new Per(newarr);
        return arr;
        // item 122
        //newarr[]
    }
	} // Вернем массив
