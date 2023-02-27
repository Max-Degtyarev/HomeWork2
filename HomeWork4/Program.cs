using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeWork4
{


    abstract class Device
    {
        protected string _name;
        protected string _type;

        public Device(string name, string type)
        {
            _name = name;
            _type = type;
        }

        abstract public void Sound();
        abstract public void Show();
        abstract public void Desk();




    }



    class Teapot : Device
    {

        int _volume;

        public Teapot(string name, string type, int volume): base(name, type)
        {

            _volume = volume;

        }

        public override void Sound()
        {

            WriteLine("УУУУУУУУУУ\n");

        }
        
        public override void Show()
        {

            WriteLine($"Название: {_name}");

        }

        public override void Desk()
        {

            WriteLine($"{_type}: чайник объемом {_volume} литров");

        }

        

    }



    class Microwave : Device
    {

        int _power;

        public Microwave(string name, string type, int power) : base(name, type)
        {

            _power = power;

        }

        public override void Sound()
        {

            WriteLine("FFFFFFFFFFFFF\n");

        }

        public override void Show()
        {

            WriteLine($"Название: {_name}");

        }

        public override void Desk()
        {

            WriteLine($"{_type}: микроволновая печь мощностью {_power} ватт");

        }



    }


    class Car : Device
    {

        int _power;
        int _speed;

        public Car(string name, string type, int power, int speed) : base(name, type)
        {

            _power = power;
            _speed = speed; 
        }

        public override void Sound()
        {

            WriteLine("ЖЖЖЖЖЖЖЖЖЖЖЖЖЖ\n");

        }

        public override void Show()
        {

            WriteLine($"Название: {_name}");

        }

        public override void Desk()
        {

            WriteLine($"{_type}: автомобиль\nОсновные характеристики:\nМощность {_power} лошадиных сил\nМаксимальная скорость {_speed} км/ч");

        }



    }




    internal class Program
    {
        static void Main(string[] args)
        {

            Device[] dev =
            {

                new Teapot("Тефаль", "Техника для дома", 10),
                new Microwave("Самсунг", "Техника для дома", 500),
                new Car("Феррари", "Транспорт", 500, 300)

            };





            foreach(Device item in dev)
            {
                item.Desk();
                item.Show();
                item.Sound();

            }



        }
    }
}
