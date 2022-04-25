using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadachi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите количество покупок:");
            //int N = int.Parse(Console.ReadLine());
            //List<string> listBuy = new List<string>(N);
            //Console.WriteLine("Ввод:");
            //for (int i = 0; i < N; i++)
            //{
            //    listBuy.Add(Console.ReadLine());
            //}
            //Console.WriteLine("Вывод:");
            //PrintList(listBuy);
            //Console.WriteLine("Отсортированный");
            //listBuy.Sort();
            //Console.WriteLine("По алфавиту:");
            //PrintList(listBuy);
            //Console.WriteLine("От Я до А:");
            //listBuy.Reverse();
            //PrintList(listBuy);

            //Console.WriteLine("Задание 2");
            //Console.WriteLine("Введите количество строк:");
            //int K = int.Parse(Console.ReadLine());
            //List<string> listString = new List<string>(K);
            //Console.WriteLine("Ввод:");
            //for (int i = 0; i < K; i++)
            //{
            //    listString.Add(Console.ReadLine());
            //}
            //Console.WriteLine("Введите искомое слово:");
            //string wordSearch = Console.ReadLine();
            //Console.WriteLine("Результат поиска:");

            //List<string> listFinded = listString.FindAll(p => p.Contains(wordSearch));

            //if(listFinded.Count > 0)
            //    PrintList(listFinded);
            //else
            //    Console.WriteLine("По вашему запросу ничего не найдено");

            //Console.WriteLine("Задание 3");
            //Console.WriteLine("Введите количество строк:");
            //int K = int.Parse(Console.ReadLine());
            //List<string> listString = new List<string>(K);
            //Console.WriteLine("Ввод:");
            //for (int i = 0; i < K; i++)
            //{
            //    listString.Add(Console.ReadLine());
            //}
            //Console.WriteLine("Номер символа:");
            //int number = int.Parse(Console.ReadLine());
            //string abreviature = " ";
            //Console.WriteLine("Результат:");
            //foreach(string line in listString)
            //{
            //    if (line.Length >= number)
            //        abreviature += line[number - 1];
            //    else
            //        abreviature += "_";
            //}
            //Console.WriteLine($"Полученное слово: {abreviature}");

            //Console.WriteLine("Задание 5");
            //Console.WriteLine("Введите количество клиентов банка:");
            //int N = int.Parse(Console.ReadLine());
            //List<int> listClients = new List<int>(N);
            //Console.WriteLine("Ввод:");
            //for (int i = 0; i < N; i++)
            //{
            //    listClients.Add(int.Parse(Console.ReadLine()));
            //}
            //Console.WriteLine("Исходные вложения:");
            //PrintList(listClients);
            //Console.WriteLine("Накопления через год:");
            //foreach(int client in listClients)
            //{
            //    Console.WriteLine(client*3);
            //}

            //Console.WriteLine("Задание 4");
            //Console.WriteLine("Введите количество записанных частей объявления:");
            //int N = int.Parse(Console.ReadLine());
            //List<string> listPart = new List<string>(N);
            //Console.WriteLine("Ввод:");
            //for (int i = 0; i < N; i++)
            //{
            //    listPart.Add(Console.ReadLine());
            //}
            //Console.WriteLine("Введите количество частей");
            //int countPart = int.Parse(Console.ReadLine());
            //List<string> spisok = new List<string>(countPart);
            //Console.WriteLine("Введите номер строки");
            //for(int i = 0; i < countPart; i++) 
            //{
            //    int numberStroka = int.Parse(Console.ReadLine());
            //    spisok.Add(listPart[numberStroka - 1]);
            //}
            //PrintList(spisok);

            Console.WriteLine("Задание 6");
            Console.WriteLine("Введите количество чисел:");
            int N = int.Parse(Console.ReadLine());
            List<int> listChisel = new List<int>(N);
            Console.WriteLine("Ввод:");
            for (int i = 0; i < N; i++)
            {
                listChisel.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Начальный");
            int p = 2;//int.Parse(Console.ReadLine());
            Console.WriteLine("Конечный");
            int q = 4;// int.Parse(Console.ReadLine());
            //var range = listChisel.GetRange(p-1, q-1);
            //int sum = 0;
            //foreach(int c in range)
            //{
            //    sum += c;
            //}
            Console.WriteLine("Вывод:");
            //Console.WriteLine(sum);
            Console.WriteLine(listChisel.GetRange(p - 1, q - 1).Sum());
            Console.ReadKey();

        }

        private static void PrintList(List<string> list)
        {
            foreach (string c in list)
            {
                Console.WriteLine(c);
            }
        }
        private static void PrintList(List<int> list)
        {
            foreach (int c in list)
            {
                Console.WriteLine(c);
            }
        }
    }
}
