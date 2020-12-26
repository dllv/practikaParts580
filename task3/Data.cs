using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task3
{
    class Data
    {
        public static int arrSize = 3;
        public static string[,] furnitureArray = new string[arrSize, 3];

        public static void addNewEntry(ref string[,] original, string name, string type, string madeBy)
        {
            arrSize++;
            string[,] newArray = new string[arrSize, 3];         //делаем новый массив
            for(int i = 0; i < arrSize-1; i++)                   //на строчку больше оригинального
            {
                Array.Copy(original, i * 3, newArray, i * 3, 3); //суём в него данные из ориг. массива
            }
            newArray[arrSize-1, 0] = name;                       //добавляем данные в новую строчку
            newArray[arrSize-1, 1] = type;                      //      \____☺  ♥      
            newArray[arrSize-1, 2] = madeBy;                   //       /    \   - это кот

            original = newArray;
        }
    }
}
