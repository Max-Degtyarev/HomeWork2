//#define TASK1
#define TASK2
//#define TASK3
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeWork3
{
    internal class Program
    {


        class Shop
        {

            string _name;
            string _address;
            string _specialisation;
            string _phone;


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



            public Shop()
            {
               

            }




            public Shop(string name, string address, string specialisation, string phone)
            {
                _name = name;
                _address = address; 
                _specialisation = specialisation;
                _phone = phone;

            }

            public void PrintInfo()
            {

                WriteLine($"Название магазина: {_name}\nАдрес: {_address}\nПрофиль: {_specialisation}\nТелефон: {_phone}");


            }





        }





        static void Main(string[] args)
        {

#if TASK1
            int number;
            WriteLine("Введите число: ");
            number = int.Parse(ReadLine());

            ispalindrom(number); 
#endif


#if TASK2

            Random rnd1 = new Random();
            int b = rnd1.Next(5, 10);

            int[] Arr1 = new int[b];

            Random rnd2 = new Random();

            for (int i = 0; i < b; i++)
            {
                Arr1[i] = rnd2.Next(0, 100);

            }

            WriteLine("Исходный массив");

            for (int i = 0; i < b; i++)
            {
                Write(Arr1[i] + " ");

            }
            WriteLine();


            int number;
            WriteLine("Введите количество элементов для удаления из первого массива");
            number = int.Parse(ReadLine());
            int[] Arr2 = new int[number];
            WriteLine("Введите элементы для удаления первого массива");
            for (int i = 0; i < number; i++)
            {
                Arr2[i] = int.Parse(ReadLine());

            }

            Arr1 = changeArr(Arr1, Arr2, b, number);


            for (int i = 0; i < Arr1.Length; i++)
            {
                Write(Arr1[i] + " ");

            }
            WriteLine(); 
#endif



#if TASK3
            Shop s1 = new Shop("Березка", "ул. Пушкина", "Продажа водки", "56685 - 56695");
            s1.PrintInfo();

            WriteLine();

            Shop s2 = new Shop();
            s2.Name = "Иволга";
            s2.Address = "ул. Маяковского";
            s2.Specialisation = "Продажа сигарет";
            s2.Phone = "8569 - 45236";
            s2.PrintInfo();

#endif

        }


        static int[] changeArr(int[] Arr1, int[] Arr2, int b, int number)
        {

            int p = b - 1;
            int count = 0;
            
            for(int i = 0; i < b; i++)
            {
                for(int j = 0; j < number; j++)
                {

                    if (Arr1[i] == Arr2[j])
                    {
                        for(int h = i; h < b - 1; h++)
                        {
                            Arr1[h] = Arr1[h + 1];
                        }
                        Arr1[p] = 0;

                        p--;
                        j--;
                        count++;                     
                        
                    }                 
                }
            }

            int[] newArr = new int[b - count];

            for(int i = 0; i < (b - count); i++)
            {
                newArr[i] = Arr1[i];

            }
            return newArr;

        }



        static void ispalindrom(int number)
        {


            int numberLength = 0;
            int copynumber1 = number;

            for (; copynumber1 > 0; numberLength++)
            {
                copynumber1 /= 10;
            }

            int a;
            int b;
            int variable = 1;
            int copynumber2 = number;

            int i = 0;

            for (; i < numberLength; i++)
            {
                a = copynumber2 / (int)Math.Pow(10, numberLength - variable);
                b = number % 10;

                copynumber2 /= 10;
                variable++;

                if (a != b)
                {
                    WriteLine("Число не палиндром");
                    break;
                }
            }
            if (i == numberLength) WriteLine("Число палиндром");


        }





    }
}
