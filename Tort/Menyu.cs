using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tort
{
    internal class Menyu
    {
        public Menyu() 
        {
            List<string> list = new List<string>() { "  1.Форма", "  2.Размер", "  3.Вкус", "  4.Декор", "  5.Глазурь", "  6.Количество коржей" };
            List<string> list1 = new List<string>() { "не заказано", "Треугольник", "Круг", "Квадрат" };
            List<int> ch1 = new List<int>() { 0, 300, 200, 400 };
            List<string> list2 = new List<string>() { "не заказано", "Маленький (300 г)", "Средний (1 кг)", "Большой (2 кг)" };
            List<int> ch2 = new List<int>() { 0, 149, 499, 999 };
            List<string> list3 = new List<string>() { "не заказано", "Клубничный", "Шоколадный", "Ванильный", "Кокосовый", "Банановый" };
            List<int> ch3 = new List<int>() { 0, 49, 99, 49, 79, 200 };
            List<string> list4 = new List<string>() { "не заказано", "Стружка", "Надпись", "Посыпка", "Свечи" };
            List<int> ch4 = new List<int>() { 0, 49, 29, 49, 199 };
            List<string> list5 = new List<string>() { "не заказано", "Без глазури", "Сахарная", "Соленая" };
            List<int> ch5 = new List<int>() { 0, 0, 300, 2000 };
            List<string> list6 = new List<string>() { "не заказано", "1 корж", "2 коржа", "3 коржа", "4 коржа", "5 коржей" };
            List<int> ch6 = new List<int>() { 0, 100, 200, 300, 400, 500 };

            ConsoleKeyInfo key;
            do
            {
                List<int> Cena = new List<int>() { 0, 0, 0, 0, 0, 0 };
                int ii = 0;
                int dengi = 0;

                do
                {
                    Console.Clear();
                    Console.WriteLine("Сдалайте заказ торта");
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(list[i]);
                    }
                    Console.WriteLine("Цена заказа - " + dengi + " руб.");
                    Console.WriteLine("Ваш заказ: " + list[0] + " - " + list1[Cena[0]]);
                    Console.WriteLine("           " + list[1] + " - " + list2[Cena[1]]);
                    Console.WriteLine("           " + list[2] + " - " + list3[Cena[2]]);
                    Console.WriteLine("           " + list[3] + " - " + list4[Cena[3]]);
                    Console.WriteLine("           " + list[4] + " - " + list5[Cena[4]]);
                    Console.WriteLine("           " + list[5] + " - " + list6[Cena[5]]);
                    Strelka menu = new Strelka(1, list.Count + 1);
                    int posit = menu.Show();
                    
                    Console.Clear();
                    Console.WriteLine("Выберите параметр");
                    int o = 0;
                    if (posit == 1)
                    {
                        for (int i = 1; i < list1.Count; i++)
                        {
                            Console.WriteLine("  " + i + ". " + list1[i] + " - цена " + ch1[i] + "руб.");
                            o = list1.Count;
                        }
                    }
                    if (posit == 2)
                    {
                        for (int i = 1; i < list2.Count; i++)
                        {
                            Console.WriteLine("  " + i + ". " + list2[i] + " - цена " + ch2[i] + "руб.");
                            o = list2.Count;
                        }
                    }
                    if (posit == 3)
                    {
                        for (int i = 1; i < list3.Count; i++)
                        {
                            Console.WriteLine("  " + i + ". " + list3[i] + " - цена " + ch3[i] + "руб.");
                            o = list3.Count;
                        }
                    }
                    if (posit == 4)
                    {
                        for (int i = 1; i < list4.Count; i++)
                        {
                            Console.WriteLine("  " + i + ". " + list4[i] + " - цена " + ch4[i] + "руб.");
                            o = list4.Count;
                        }
                    }
                    if (posit == 5)
                    {
                        for (int i = 1; i < list5.Count; i++)
                        {
                            Console.WriteLine("  " + i + ". " + list5[i] + " - цена " + ch5[i] + "руб.");
                            o = list5.Count;
                        }
                    }
                    if (posit == 6)
                    {
                        for (int i = 1; i < list6.Count; i++)
                        {
                            Console.WriteLine("  " + i + ". " + list6[i] + " - цена " + ch6[i] + "руб.");
                            o = list6.Count;
                        }
                    }
                    Strelka men1 = new Strelka(1, o + 1);
                    int pos = men1.Show();
                    Console.Clear();
                    Cena[posit - 1] = pos;
                    dengi = ch1[Cena[0]] + ch2[Cena[1]] + ch3[Cena[2]] + ch4[Cena[3]] + ch5[Cena[4]] + ch6[Cena[5]];
    
                    if (Cena.Contains(0) == false)
                    {
                        ii = 1;
                    }
                }
                while (ii != 1);
                string txt = "\nЗаказ: " + list[0] + "-" + list1[Cena[0]] + "," + list[1] + "-" + list2[Cena[1]] + "," + list[2] + "-" + list3[Cena[2]] + "," + list[3] + "-" + list4[Cena[3]] + "," + list[4] + "-" + list5[Cena[4]] + ", " + list[5] + "-" + list6[Cena[5]];
                Console.WriteLine(txt);
                File.AppendAllText("C:\\Users\\adv_m\\Downloads\\История заказов.txt", "\nДата заказа: " + DateTime.Now);
                File.AppendAllText("C:\\Users\\adv_m\\Downloads\\История заказов.txt", txt);
                File.AppendAllText("C:\\Users\\adv_m\\Downloads\\История заказов.txt", "\nЦена: " + dengi + "руб.");
                Console.WriteLine("Спасибо за заказ. Сделать заказ - Enter. Выход - Escape");
                key = Console.ReadKey();
            }
            while (key.Key != ConsoleKey.Escape);
        }
    }
    
}