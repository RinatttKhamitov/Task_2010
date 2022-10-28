using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2010
{
    class Program
    {
        static void Main(string[] args)
        {
            SparePartsCatalog store = new BikePartsStore();

            Console.WriteLine("Куда ты хочешь пойти: \n 1) магазин запчастей для велосипеда \n 2) магазин запчастей для авто");
            string command = Console.ReadLine();

            if (command.Equals("1"))
            {
                store = new BikePartsStore();
                store.StoreEntrance();
            }
            else if (command.Equals("2"))
            {
                store = new CarePartsStore();
                store.StoreEntrance();
            }
            else
            {
                Console.WriteLine("Вы не вошли в магазин");
            }
            int money = 1000;
            List<string> DataSalesman = File.ReadLines("C:/Users/stone/source/repos/Task_2010/Task_2010/salesman.txt").ElementAtOrDefault(0).Split(';').ToList();
            store.Salesman = new Employee(DataSalesman[0], int.Parse(DataSalesman[1]), int.Parse(DataSalesman[2]));
            Console.Clear();
            Console.WriteLine("Команда ( help ) для помощи");
            Console.WriteLine($"У вас {money} руб");
            while (!command.Equals("4"))
            {
                command = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Команда ( help ) для помощи");
                Console.WriteLine($"У вас {money} руб");

                switch (command)
                {
                    case "1":
                        Command1(store);
                        break;
                    case "2":

                        if (store.Entrance)
                        {
                            money -= 100;
                        }
                        Console.Write("Что вы хотите купить: ");
                        Command2(store, Console.ReadLine());
                        break;
                    case "3":

                        break;
                    case "help":
                        Menu();
                        break;
                }
            }

        }
        static public void Command1(SparePartsCatalog catalog)
        {
            catalog.CatalogOfThings();
        }
        static public void Command2(SparePartsCatalog catalog, string product)
        {
            catalog.Purchase(product);
        }


        static public void Menu()
        {
            Console.WriteLine("Команды");
            Console.WriteLine("1) узнать ассортимент товаров в наличии");
            Console.WriteLine("2) купить товар");
            Console.WriteLine("3) сделать возврат");
            Console.WriteLine("4) Выход из программы");
        }
    }
}
