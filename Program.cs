using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //сума від'ємних елементів масива
            int A[30];
            int suma;//змінна,що містить суму
            int i;//додаткова змінна
                  //Введення масива 
                  //...

            // Розв'язок 
            suma = 0;
            for (i = 0; i < 30; i++)
                if (A[i] > 0)
                    suma = suma + A[i];
        }
    }
}
