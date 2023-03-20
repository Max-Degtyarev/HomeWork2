using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Console;




namespace HomeWork6
{


    public interface IWorker
    {
        string Name { get; set; }
        void Work(IPart part);

    }


    public interface IPart
    {
       
        void Building();

    }



    class House
    {
        
        public void HouseIsDone()
        {
            WriteLine("Дом построен");

        }
               

    }



    class Basement : IPart
    {
       
        public void Building()
        {
            WriteLine(" - Фундамент готов");

        }

    }


    class Walls : IPart
    {
        
        public void Building()
        {
            WriteLine(" - Стена готова");

        }

    }

    class Door : IPart
    {
        
        public void Building()
        {
            WriteLine(" - Дверь готова");

        }

    }


    class Window : IPart
    {
        
        public void Building()
        {
            WriteLine(" - Окно готово");

        }

    }

    class Roof : IPart
    {
        
        public void Building()
        {
            WriteLine(" - Крыша готова");

        }

    }




    class Worker : IWorker
    {

        public string Name { get; set; }
        
        public Worker(string name)
        {
            Name = name;
            
        }

        public void Work(IPart part)
        {
            part.Building();
         
        }

    }



    class Team
    {

        public Worker[] team;

        public Team(int size)
        {

            team = new Worker[size];

        }
       

        public Worker this[int index]
        {

            get
            {

                if (index >= 0 && index < team.Length)
                {
                    return team[index];

                }
                throw new IndexOutOfRangeException();

            }

            set
            {

                team[index] = value;

            }

        }



    }



    internal class Program
    {
        static void Main(string[] args)
        {

            Team team1 = new Team(4);

            team1[0] = new Worker("Строитель 1");
            team1[1] = new Worker("Строитель 2");
            team1[2] = new Worker("Строитель 3");
            team1[3] = new Worker("Строитель 4");


            List<IPart> list = new List<IPart>
            {
                new Basement(),
                new Walls(),
                new Walls(),
                new Walls(),
                new Walls(),
                new Door(),
                new Window(),
                new Window(),
                new Window(),
                new Window(),
                new Roof()
            };


            Random rand = new Random();
            

            for(int i = 0; i <= list.Count - 1; i++)
            {
                int number = (int)rand.Next(0, 4);

                Write(team1[number].Name);
                team1[number].Work(list[i]);


            }

            House house = new House();
            house.HouseIsDone();




        }
    }
}
