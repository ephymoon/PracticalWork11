using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        public static void Values(int choise, ref Building building, ref Apartment apartment, ref Mall mall, ref Office office)
        {
            if (choise != 1)
            {
                Console.WriteLine("Класс Building");
                Console.WriteLine("Введите город, адрес, высоту.");
                building.city = Console.ReadLine();
                building.address = Console.ReadLine();
                building.height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Класс Apartment");
                Console.WriteLine("Введите город, адрес, высоту, арендную плату(по суточно).");
                apartment.city = Console.ReadLine();
                apartment.address = Console.ReadLine();
                apartment.height = Convert.ToDouble(Console.ReadLine());
                apartment.rent = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Класс Mall");
                Console.WriteLine("Введите город, адрес, высоту, название тц.");
                mall.city = Console.ReadLine();
                mall.address = Console.ReadLine();
                mall.height = Convert.ToDouble(Console.ReadLine());
                mall.name = Console.ReadLine();
                Console.WriteLine("Класс Office");
                Console.WriteLine("Введите город, адрес, высоту, название компании.");
                office.city = Console.ReadLine();
                office.address = Console.ReadLine();
                office.height = Convert.ToDouble(Console.ReadLine());
                office.company = Console.ReadLine();

            }
            else Console.WriteLine("Значения заданы по умолчанию.");
        }

        public static void Cout(ref Building building, ref Apartment apartment, ref Mall mall, ref Office office)
        {
            Console.WriteLine("Класс Building.");
            building.Print();
            Console.WriteLine("\nКласс Apartment.");
            apartment.Print();
            Console.WriteLine("Метод для класса:");
            apartment.Count();
            Console.WriteLine("\nКласс Mall.");
            mall.Print();
            Console.WriteLine("Метод для класса:");
            mall.Ad();
            Console.WriteLine("\nКласс Office.");
            office.Print();
            Console.WriteLine("Метод для класса:");
            office.Work();
        }

        static void Main(string[] args)
        {
            Building building = new Building();
            Apartment apartment = new Apartment();
            Mall mall = new Mall();
            Office office = new Office();
        test:
            Console.Clear();
            Console.Write("\n1.Назначение программы.\n2.Указания пользователю.\n3.Выбор: задавать значения по стандарту или самостоятельно\n4.Вывод всех объектов и методов\n0.Выход из программы.");
            Console.Write("\nВыберите действие: ");

            switch (Console.ReadLine())
            {
                case ("1"):
                    Console.Clear();
                    Console.WriteLine("Программа классов зданий.");
                    Console.Write("Нажмите любую клавишу, чтобы продолжить...");
                    Console.ReadKey();
                    goto test;
                case ("2"):
                    Console.Clear();
                    Console.WriteLine("Для работы программы просто выберите соответсвубщий пункт меню, а позже при необходимости введите соответствующие данные.");
                    Console.Write("Нажмите любую клавишу, чтобы продолжить...");
                    Console.ReadKey();
                    goto test;
                case ("3"):
                    Console.Clear();
                    Console.Write("Нажмите 1, чтобы задать значения по умолчанию. 2 чтобы задать значения самостоятельно.");
                    int choise = Convert.ToInt32(Console.ReadLine());
                    Values(choise, ref building, ref apartment, ref mall, ref office);
                    goto test;
                case ("4"):
                    Console.Clear();
                    Cout(ref building, ref apartment, ref mall, ref office);
                    Console.Write("Нажмите любую клавишу, чтобы выйти из просмотра...");
                    Console.ReadKey();
                    goto test;
                case ("0"):
                    break;
                default:
                    Console.WriteLine("Несуществующий вариант, повторите попытку.");
                    goto test;
            }
            Console.Write("Нажмите любую клавишу, чтобы завершить работу программы...");
            Console.ReadKey();
        }
    }
}
