#define TASK1
//#define TASK2
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;



namespace HomeWork5
{

#if TASK1
    class Shop
    {

        string _name;
        string _address;
        string _specialisation;
        string _phone;
        double _area;


        public string Name
        {
            get
            {
                return _name;

            }

            set
            {
                _name = value;

            }

        }


        public string Address
        {

            get
            {
                return _address;

            }

            set
            {

                _address = value;

            }

        }

        public string Specialisation
        {

            get
            {
                return _specialisation;

            }

            set
            {
                _specialisation = value;

            }

        }


        public string Phone
        {
            get
            {
                return _phone;

            }

            set
            {

                _phone = value;

            }



        }

        public double Area
        {

            get
            {
                return _area;
            }

            set
            {
                _area = value;
            }


        }


        public Shop()
        {


        }



        public Shop(string name, string address, string specialisation, string phone, double area)
        {
            _name = name;
            _address = address;
            _specialisation = specialisation;
            _phone = phone;
            _area = area;

        }

        public void PrintInfo()
        {

            WriteLine($"Название магазина: {_name}\nАдрес: {_address}\nПрофиль: {_specialisation}\nТелефон: {_phone}\nПлощадь: {_area} кв.м\n");


        }


        public static Shop operator +(Shop s, double area)
        {

            Shop buffer = s;
            buffer._area += area;
            return buffer;
        }

        public static Shop operator -(Shop s, double area)
        {

            Shop buffer = s;
            buffer._area -= area;
            return buffer;
        }


        public bool Equals(Shop obj)
        {
            if (this.Area == obj.Area)
            {
                WriteLine($"Площадь магазина {this.Name} и {obj.Name} равна");

            }
            else
            {
                WriteLine($"Площадь магазина {this.Name} и {obj.Name} не равна");

            }

            return this.Area == obj.Area;



        }



        public static bool operator ==(Shop s1, Shop s2)
        {

            return s1.Equals(s2);


            //if(s1.Area == s2.Area)
            //{
            //    WriteLine($"Площадь магазина {s1.Name} и {s2.Name} равна");

            //}
            //else
            //{
            //    WriteLine($"Площадь магазина {s1.Name} и {s2.Name} не равна");

            //}

            //return s1.Area == s2.Area;


        }

        public static bool operator !=(Shop s1, Shop s2)
        {

            if (s1.Area != s2.Area)
            {
                WriteLine($"Площадь магазина {s1.Name} и {s2.Name} не равна");

            }
            else
            {
                WriteLine($"Площадь магазина {s1.Name} и {s2.Name} равна");

            }

            return s1.Area != s2.Area;


        }



        public override string ToString()
        {
            return $"Название магазина: {_name}\nАдрес: {_address}\nПрофиль: {_specialisation}\nТелефон: {_phone}\nПлощадь: {_area} кв.м\n";
        }



    } 
#endif


   




    internal class Program
    {
        static void Main(string[] args)
        {

#if TASK1
            Shop s1 = new Shop("Березка", "ул. Пушкина", "Продажа водки", "56685 - 56695", 52.56);
            s1.PrintInfo();


            Shop s2 = new Shop();
            s2.Name = "Иволга";
            s2.Address = "ул. Маяковского";
            s2.Specialisation = "Продажа сигарет";
            s2.Phone = "8569 - 45236";
            s2.Area = 85.63;
            s2.PrintInfo();


            WriteLine(s2);


            s1 = s1 + 15.85;
            WriteLine(s1);
            s1 += 52.86;
            WriteLine(s1);

            WriteLine(s1 == s2);

            s1 -= 35.64;
            WriteLine(s1);

            WriteLine(s1 != s2); 
#endif



#if TASK2
            List<string> list = new List<string>
            {
                "Мастер и Маргарита",
                "Война и мир",
                "Преступление и наказание"


            };

            foreach (string item in list)
            {
                WriteLine(item);

            }

            WriteLine();

            WriteLine("Введите название книги для добавления в список: ");
            string addbook = ReadLine();

            list.Add(addbook);

            WriteLine();

            foreach (string item in list)
            {
                WriteLine(item);

            }

            WriteLine();

            WriteLine("Введите название книги для удаления из списка: ");
            string removebook = ReadLine();

            bool a = false;

            for (int i = 0; i < list.Count; i++)
            {

                if (list[i].Contains(removebook))
                {
                    list.RemoveAt(i);
                    a = true;
                }


            }

            if (!a) WriteLine("Данной книги в списке нет");

            WriteLine();

            foreach (string item in list)
            {
                WriteLine(item);

            } 
#endif


            




        }
    }
}
