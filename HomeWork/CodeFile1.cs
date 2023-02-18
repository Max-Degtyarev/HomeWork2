using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace HomeWork
{


    internal class Program2
    {
        static void startQuiz()
        {

            bool gameagain = true;

            do
            {

                string[] questions =
                {
                "Зимой и летом одним цветом?",
                "Самая высокая гора?",
                "Самая длинная река?",
                "Самый большой океан?",
                "Самая большая планета?"
                };

                string[][] answers = new string[][]
                {
                new string[] { "елка", "ёлка", "ель" },
                new string[] { "эверест", "джомолунгма" },
                new string[] { "амазонка" },
                new string[] { "тихий", "тихий океан" },
                new string[] { "юпитер" }

                };


                string userAnswer;
                int counter = 0;

                for (int i = 0; i < questions.Length; i++)
                {
                    WriteLine(questions[i]);
                    userAnswer = ReadLine().ToLower();
                    bool answer = false;


                    for (int j = 0; j < answers[i].Length; j++)
                    {
                        if (userAnswer == answers[i][j])
                        {
                            counter++;
                            answer = true;
                        }

                        if(!answer)
                        {
                            int a = answers[i][j].Length - (answers[i][j].Length - 1);
                            string tip = answers[i][j].Remove(a);

                            WriteLine($"Подсказка: ответ начинается с буквы \"{tip}\"");
                            WriteLine("Введите ещё раз ответ:");
                            userAnswer = ReadLine().ToLower();
                            for (int k = 0; k < answers[i].Length; k++)
                            {
                                if (userAnswer == answers[i][k])
                                {
                                    counter++;
                                    answer = true;
                                }
                            }
                            break;
                        }



                    }


                    if (answer)
                    {
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

                WriteLine("Хотите ещё раз пройти викторину? (да - 1, нет - 0)");
                int again = Int32.Parse(ReadLine());
                if (again == 1) gameagain = true;
                else if (again == 0) gameagain = false;


            } while (gameagain);


        }



        static void guessNumber()
        {

            Random rand = new Random();
            int number = rand.Next(0, 100);
            int usernumber;
            int attempts = 10;
            int count = 0;
            bool gameover = true;


            do
            {

                WriteLine("Угадайте число от 0 до 100: ");
                usernumber = Int32.Parse(ReadLine());
                attempts--;
                count++;

                if(usernumber > number)
                {
                    WriteLine("Загаданное число меньше\n");
                }
                else if (usernumber < number)
                {
                    WriteLine("Загаданное число больше\n");
                }

                if(attempts == 0)
                {
                    gameover = false;

                }

                if(number != usernumber && gameover)
                {
                    WriteLine($"Осталось попыток: {attempts}");

                }


            } while (number != usernumber && gameover);

            if(number == usernumber)
            {
                WriteLine("Вы угадали");
                WriteLine("Вам понадобилось " + count + " попыток");
            }
            else
            {
                WriteLine("Попытки закончились, вы проиграли");
                WriteLine("Было загалано число {0}", number);

            }



        }


        static void Main(string[] args)
        {

            WriteLine("В какую игру будете играт? (1 - викторина, 2 - угадай число)");
            int number = Int32.Parse(ReadLine());

            if(number == 1) startQuiz();
            else if(number == 2) guessNumber();


        }
    }
}
