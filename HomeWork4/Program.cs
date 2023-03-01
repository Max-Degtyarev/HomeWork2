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
        protected int _power;

        public Device(string name, int power)
        {
            _name = name;
            _power = power;
        }

        abstract public void Sound();
        abstract public void Show();
        abstract public void Desk();

    }



    abstract class Appliance : Device
    {
        protected int _volume;
        
        public Appliance(string name, int power, int volume):base(name, power)
        {
            _volume = volume;
            
        }
    }


    abstract class Transport : Device
    {
        protected int _maxspeed;
        
        public Transport(string name, int power, int maxspeed):base(name, power)
        {
            _maxspeed = maxspeed;

        }

    }


    class Teapot : Appliance
    {

        string _case;

        public Teapot(string name, int power, int volume, string casee): base(name, power, volume)
        {
            _case = casee;

        }

        public override void Sound()
        {

            WriteLine("Звук: УУУУУУУУУУ\n");

        }
        
        public override void Show()
        {

            WriteLine($"Тип устройства: электрический чайник\nНазвание: {_name}");

        }

        public override void Desk()
        {

            WriteLine($"Основные характеристики:\nОбъем: {_volume} литров\nМощность: {_power} ватт\nМатерил корпуса: {_case}");

        }
    
    }


    class Microwave : Appliance
    {

        string _country;

        public Microwave(string name, int power, int volume, string country) : base(name, power, volume)
        {

            _country = country;

        }

        public override void Sound()
        {
           WriteLine("Звук: Ж-Ж-Ж-Ж-Ж-Ж-Ж-Ж-Ж-Ж\n");

        }

        public override void Show()
        {

            WriteLine($"Тип устройства: микроволновая печь\nНазвание: {_name}");

        }

        public override void Desk()
        {

            WriteLine($"Основные характеристики:\nОбъем: {_volume} литров\nМощность: {_power} ватт\nСтрана производства: {_country}");

        }

    }


    class Car : Transport
    {

        string _color;

        
        public Car(string name, int power, int maxspeed, string color) : base(name, power, maxspeed)
        {

            _color = color;
           
        }

        public override void Sound()
        {

            WriteLine("Звук: ВЖУУУУХ\n");

        }

        public override void Show()
        {

            WriteLine($"Тип устройства: автомобиль\nНазвание: {_name}");

        }

        public override void Desk()
        {

            WriteLine($"Основные характеристики:\nМощность: {_power} лошадиных сил\nМаксимальная скорость: {_maxspeed} км/ч\nЦвет: {_color}");

        }


    }



    class Steamer : Transport
    {

        int _displacement;

        public Steamer(string name, int power, int maxspeed, int disp):base(name, power, maxspeed)
        {

            _displacement = disp;

        }

        public override void Sound()
        {

            WriteLine("Звук: Ш-Ш-Ш-Ш-Ш-Ш-Ш-Ш-Ш-Ш-Ш-Ш-Ш-Ш\n");

        }

        public override void Show()
        {

            WriteLine($"Тип устройства: Пароход\nНазвание: {_name}");

        }

        public override void Desk()
        {

            WriteLine($"Основные характеристики:\nМощность: {_power} лошадиных сил\nМаксимальная скорость: {_maxspeed} узлов\nВодоизмещение: {_displacement} тонн");

        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Device[] dev =
            {

                new Teapot("Тефаль", 300, 500, "Металл"),
                new Microwave("Самсунг", 700, 500, "Китай"),
                new Car("Феррари", 900, 350, "Синий"),
                new Steamer("Князь Владимир", 3000, 25, 150000)

            };



            foreach(Device item in dev)
            {
                item.Show();
                item.Desk();
                item.Sound();

            }



        }
    }
}
