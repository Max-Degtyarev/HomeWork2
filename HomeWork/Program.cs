using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace HomeWork
{


    internal class Program
    {
        static void Main2(string[] args)
        {


            string[] questions =
            {
                "Зимой и летом одним цветом?",
                "Самая высокая гора?",
                "Самая длинная река?",
                "Самый большой океан?",
                "Самая большая планета?"
            };

            string[] answers =
            {
                "ёлка",
                "эверест",
                "амазонка",
                "тихий",
                "юпитер"
            };

            string userAnswer;
            int counter = 0;
            
            for(int i = 0; i < questions.Length; i++)
            {
                WriteLine(questions[i]);
                userAnswer = ReadLine().ToLower();
                if(userAnswer == answers[i])
                {
                    counter++;
                    WriteLine("Ответ верный!\n");
                }
                else
                {
                    WriteLine("Ответ неверный!\n");
                }

            }
            WriteLine("Правильных ответов: " + counter);

            if (counter >= 4) WriteLine("Молодец! Хороший результат");
            else if (counter == 3 || counter == 2) WriteLine("Средний результат");
            else if (counter < 2) WriteLine("Плохой результат, надо еще тренироваться");





        }
    }
}
