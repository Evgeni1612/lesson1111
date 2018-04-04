using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace вывод_имен
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();
            myList.Add("Вахид");
            myList.Add("Евгений");
            myList.Add("Антон");
            myList.Add("Рамазан");
            myList.Add("Коля");



            List<int> tempList = new List<int>();
            Random r = new Random();
            string[] myTempString = new string[myList.Count];
            int myTempNumber = 0;

            for (int i = 0; i < myList.Count; i++)
            {
                myTempNumber = r.Next(myList.Count);

                if (tempList.Contains(myTempNumber))
                    i--;
                else
                {
                    tempList.Add(myTempNumber);
                    myTempString[myTempNumber] = myList[i];
                }
            }
            myList.Clear();
            for (int i = 0; i < myTempString.Length; i++)
            {
                myList.Add(myTempString[i]);
                Console.WriteLine(myList[i]);
            }
            Console.ReadKey();
        }
    }
}
