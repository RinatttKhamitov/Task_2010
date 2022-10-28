using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { };
            Bank bank = new Bank();
            bank.Print();
            Console.WriteLine();
            Console.WriteLine("2");
            Bank2 bank2 = new Bank2();
            SetAccountNumber(ref list, ref bank2);
            bank2.Print();

            Console.WriteLine();
            Console.WriteLine("3");
            Bank3 bank3 = new Bank3();
            bank3.Deposit(10000);
            bank3.Withdraw(100);
            bank3.Print();

            Console.WriteLine();
            Console.WriteLine("ДЗ");
            Home home = new Home();
            home.GetNumber();
            home.Height = 50;
            home.NumberOfStoreys = 5;
            home.NumberOfApartments = 65;
            home.Entrances = 5;
            home.GetEntrances();
            home.GetFloorHeight(3);
            home.GetFloorFlat();
            Console.ReadKey();
        }

        static void SetAccountNumber(ref List<int> list, ref Bank2 bank)
        {
            Random rnd = new Random();

            //Получить случайное число (в диапазоне от 0 до 10)
            int value = rnd.Next(1000000, 10000000);
            while (list.Contains(value))
            {
                value = rnd.Next(1000000, 10000000);
            }
            bank.AccountNumber = value;
            list.Add(value);
        }
    }
    class Bank
    {

        protected int accountNumber = 1234567342;
        protected string password = "123321";
        enum BankType { current, savings }
        private BankType BankAccountType = BankType.current;
        public int AccountNumber
        {
            get
            {
                Console.Write("Введи пароль: ");
                if (Console.ReadLine() == password)
                {
                    return accountNumber;
                }
                else
                {
                    return 0;
                }
            }
        }

        protected int balance = 10000;

        public int Balance
        {
            get
            {
                Console.Write("Введи пароль: ");
                if (Console.ReadLine() == password)
                {
                    return balance;
                }
                else
                {
                    Console.WriteLine("ERROR");
                    return 0;
                }
            }

        }
        public void Print()
        {
            Console.Write("Введи пароль: ");
            if (Console.ReadLine() == password)
            {
                Console.Write($"номер счета {accountNumber} \nбаланс {balance} \nтип банковского счета {BankAccountType}");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }



    class Bank2
    {

        protected int accountNumber = 1234567342;
        protected string password = "123321";
        enum BankType { current, savings }
        private BankType BankAccountType = BankType.current;
        public int AccountNumber
        {
            get
            {
                Console.Write("Введи пароль: ");
                if (Console.ReadLine() == password)
                {
                    return accountNumber;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                accountNumber = value;
            }
        }

        protected int balance = 10000;

        public int Balance
        {
            get
            {
                Console.Write("Введи пароль: ");
                if (Console.ReadLine() == password)
                {
                    return balance;
                }
                else
                {
                    Console.WriteLine("ERROR");
                    return 0;
                }
            }

        }
        public void Print()
        {
            Console.Write("Введи пароль: ");
            if (Console.ReadLine() == password)
            {
                Console.Write($"номер счета {accountNumber} \nбаланс {balance} \nтип банковского счета {BankAccountType}");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
    class Bank3
    {

        protected int accountNumber = 1234567342;
        protected string password = "123321";
        enum BankType { current, savings }
        private BankType BankAccountType = BankType.current;
        public int AccountNumber
        {
            get
            {
                Console.Write("Введи пароль: ");
                if (Console.ReadLine() == password)
                {
                    return accountNumber;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                accountNumber = value;
            }
        }

        protected int balance;
        public int Balance
        {
            get
            {
                Console.Write("Введи пароль: ");
                if (Console.ReadLine() == password)
                {
                    return balance;
                }
                else
                {
                    Console.WriteLine("ERROR");
                    return 0;
                }
            }

        }
        public void Print()
        {
            Console.Write("Введи пароль: ");
            if (Console.ReadLine() == password)
            {
                Console.Write($"номер счета {accountNumber} \nбаланс {balance} \nтип банковского счета {BankAccountType}");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
        public void Withdraw(int money)
        {
            if (balance >= money)
            {
                balance -= money;
            }
            else
            {
                Console.WriteLine("Нету денег на счете");
            }
        }
        public void Deposit(int money)
        {
            balance += money;
        }
    }
    class Home
    {
        protected int buildingNumber;
        public int BuildingNumber
        {
            get
            {
                return buildingNumber;
            }
            set
            {
                buildingNumber = value;
            }
        }
        public static int AllBuildingNumbers = 0;
        public double Height { get; set; }
        public int NumberOfStoreys { get; set; }
        public int NumberOfApartments { get; set; }
        public int Entrances { get; set; }
        public void GetNumber()
        {
            AllBuildingNumbers++;
            buildingNumber = AllBuildingNumbers;
        }
        public void GetFloorHeight(int floor)
        {
            Console.WriteLine($"высота этажа = {(double)((Height * floor) / NumberOfStoreys)}");
        }
        public void GetEntrances()
        {
            Console.WriteLine($"количество квартир в подъезде = {NumberOfApartments/ Entrances}");
        }
        public void GetFloorFlat()
        {
            Console.WriteLine($"количество квартир на этаже = {NumberOfApartments / NumberOfStoreys}");
        }

    }

}
