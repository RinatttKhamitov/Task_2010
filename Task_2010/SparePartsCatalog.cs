using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2010
{
    
        
    abstract class SparePartsCatalog
    {
        public bool Entrance;
        public abstract Employee Salesman { get; set; }
        public abstract void StoreEntrance(); // Вход в магазин
        public abstract void Purchase(string product); // Покупка
        public abstract void CatalogOfThings(); // каталог вещей (Что есть на складе)


    }

    class BikePartsStore : SparePartsCatalog
    {
        public override Employee Salesman { get; set; }
        public List<string> Storage = File.ReadLines("C:/Users/stone/source/repos/Task_2010/Task_2010/storage.txt").ElementAtOrDefault(0).Split(';').ToList();

        public bool Entrance { get; set; }

        public override void StoreEntrance()
        {
            Console.WriteLine();
            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine("Вы вошли в магазин");
            Entrance = true;
        }

        public override void Purchase(string product)
        {
            if (Entrance)
            {
                Console.WriteLine();
                Console.WriteLine("________________________________________________________________________");

                if (Salesman != null & Salesman.Workable)
                {
                    if (Storage.Contains(product))
                    {
                        Storage.Remove(product);
                        Console.WriteLine($"Вы купили {product}");
                    }
                    else
                    {
                        Console.WriteLine($"У нас нет товара {product}");
                    }
                }
                else
                {
                    Console.WriteLine($"Нету продавца чтобы купить {product}");
                }
            }
            else
            {
                Console.WriteLine("Вы не вошли в магазин");
            }
            
        }

        public override void CatalogOfThings()
        {
            if (Entrance)
            {
                Console.WriteLine();
                Console.WriteLine("________________________________________________________________________");
                foreach (string product in Storage)
                {
                    Console.WriteLine(product);
                }
            }
            else
            {
                Console.WriteLine("Вы не вошли в магазин");
            }
        }
    }
    class CarePartsStore : SparePartsCatalog
    {
        public override Employee Salesman { get; set; }
        public List<string> Storage = File.ReadLines("C:/Users/stone/source/repos/Task_2010/Task_2010/storageCar.txt").ElementAtOrDefault(0).Split(';').ToList();

        public bool Entrance { get; set; }

        public override void StoreEntrance()
        {
            Console.WriteLine();
            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine("Вы вошли в магазин");
            Entrance = true;
        }

        public override void Purchase(string product)
        {
            if (Entrance)
            {
                Console.WriteLine();
                Console.WriteLine("________________________________________________________________________");

                if (Salesman != null & Salesman.Workable)
                {
                    if (Storage.Contains(product))
                    {
                        Storage.Remove(product);
                        Console.WriteLine($"Вы купили {product}");
                    }
                    else
                    {
                        Console.WriteLine($"У нас нет товара {product}");
                    }
                }
                else
                {
                    Console.WriteLine($"Нету продавца чтобы купить {product}");
                }
            }
            else
            {
                Console.WriteLine("Вы не вошли в магазин");
            }

        }

        public override void CatalogOfThings()
        {
            if (Entrance)
            {
                Console.WriteLine();
                Console.WriteLine("________________________________________________________________________");
                foreach (string product in Storage)
                {
                    Console.WriteLine(product);
                }
            }
            else
            {
                Console.WriteLine("Вы не вошли в магазин");
            }
        }

    }
}
