using System;
using System.Collections;

namespace BinaryTree
{
    class Program
    {
        static void Main()
        {
            Tree tr = new Tree();
            Console.WriteLine("Введите количество вершин: ");
            int a = Convert.ToInt16(Console.ReadLine()) + 1;
            ArrayList arr = new ArrayList(a);
            while (a-- > 1)
            {
                Console.WriteLine("Введите " + a + " вершину");
                int temp = Convert.ToInt16(Console.ReadLine());
                arr.Add(temp);
            }
            foreach (int item in arr)// заполняем arraylist
            {
                if (tr.Insert(item))
                {
                    Console.WriteLine("Вершина " + a + " вставлено успешно!");
                    a++;
                }
                else
                {
                    Console.WriteLine("Вершину " + a + " не удалось вставить!");
                    a++;
                }
            }

            Console.WriteLine("Введите число до которого идём: ");
            int temp1 = Convert.ToInt32(Console.ReadLine());
            if(arr.Contains(temp1))
            {
                tr.CountSum(temp1);
                Console.WriteLine("Сумма цифр от корня до искомой вершины: " + tr.countSum);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Такого числа в дереве нет!");
            }   
        }
    }
}
