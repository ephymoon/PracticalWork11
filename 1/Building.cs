using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1
{
    public class Building // sealed - нельзя наследовать
    {
        public string city;
        public string address;
        public double height;
        public Building()
        {
            city = "Москва";
            address = "Пушкина 52";
            height = 20;
        }
        public Building(string city, string address, double height)
        {
            this.city = city;
            this.address = address;
            this.height = height;
        }
        public Building(Building p1)
        {
            this.height = p1.height;
            this.city = p1.city;
            this.address = p1.address;
        }
        public virtual void Print()
        {
            Console.WriteLine("Дом в " + city + ", по адресу " + address + ", высотой " + height + "м.");
        }
    }
    public class Apartment:Building
    {
        public int rent;
        public Apartment()
        : base()
        {
            rent = 10000;
        }
        public Apartment(string city, string address, double height, int rent)
        : base(city, address, height)
        {
            this.rent = rent;
        }
        public Apartment(Apartment x1)
        : base(x1.city, x1.address, x1.height)
        {
            rent = x1.rent;
        }
        public override void Print()
        {
            Console.WriteLine("Жилой дом в " + city + ", по адресу " + address + ", высотой " + height + "м." + "Стоимость аренды в сутки: " + rent + " руб.");
        }
        public void Count()
        {
            Console.WriteLine("Введите сколько суток будете проживать: ");
            int days = Convert.ToInt32(Console.ReadLine());
            days *= rent;
            Console.WriteLine("Общая сумма для аренды: " + days + "руб.");
        }
    }
    public class Mall : Building
    {
        public string name;
        public Mall()
        : base()
        {
            name = "Неизвестен";
        }
        public Mall(string city, string address, double height, string name)
        : base(city, address, height)
        {
            this.name = name;
        }
        public Mall(Mall x1)
        : base(x1.city, x1.address, x1.height)
        {
            name = x1.name;
        }
        public override void Print()
        {
            Console.WriteLine("Торговый центр " + name + " в " + city + ", по адресу " + address + ", высотой " + height + "м.");
        }
        public void Ad()
        {
            Console.WriteLine("Летние скидки в торговом центре " + name + ", до 90%. Контактный адрес: +79827214724");
        }
    }
    public class Office : Building
    {
        public string company;
        public Office()
        : base()
        {
            company = "Неизвестная";
        }
        public Office(string city, string address, double height, string company)
        : base(city, address, height)
        {
            this.company = company;
        }
        public Office(Office x1)
        : base(x1.city, x1.address, x1.height)
        {
            company = x1.company;
        }
        public override void Print()
        {
            Console.WriteLine("Офисное здание " + " в " + city + ", по адресу " + address + ", высотой " + height + "м." + " В здании располагается компания " + company + ".");
        }
        public void Work()
        {
            Console.WriteLine("Компания " + company + " приглашает на работу молодых специалистов в сфере IT. По вопросам трудоустройства обращайтесь к секретарю на 1м этаже.");
        }
    }
}
