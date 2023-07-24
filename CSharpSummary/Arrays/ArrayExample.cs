using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSummary.Arrays
{
    internal class ArrayExample
    {
        public void PrintArray()
        {
            //int[] values = new int[3] { 1, 2 }; //number of elements must be equal to the specified size
            int[] nums = new int[5] { 10, 15, 16, 8, 6 };

            nums.Max(); // returns 16
            nums.Min(); // returns 6
            nums.Sum(); // returns 55
            nums.Average(); // returns 55

            int[] arr = new int[5];
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr3 = {1,2,3,4,5};
            var arr4 = new int[5] { 1, 2, 3, 4, 5 };
            var arr5 = new int[] { 1, 2, 3, 4};


            // Crear un array multidimensional de 3x3 (2 dimensiones)
            int[,] matriz = new int[,]
            {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
            };

            // Límite superior de la primera dimensión (filas)
            int filas = matriz.GetUpperBound(0) + 1;
            // Límite superior de la segunda dimensión (columnas)
            int columnas = matriz.GetUpperBound(1) + 1;


            using var fileInfo = new StreamReader("path");
            var data = fileInfo.ReadToEnd();

            int pos = 3;
            //int[] arrayCustom = new int[pos] {3, 4, 5};//compile time error

            const int length = 3;
            int[] arrayCustom2 = new int[length] { 3, 4, 5 };//compile time error
        }

    }
}
