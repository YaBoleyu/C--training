﻿/*
1) метод, в которые передается массив чисел и число, 
если при добавлении данного числа к элементу массива получается число больше 10, 
элемент удаляется из массива.

2) Метод который выводит поздравление с днем рождения в консоль, имя человека передается в метод

3) Метод который получает число, возвращает true, если это простое число. 
В коде, если это оказалось простое число, выводим его в консоль, с надписью, что это простое число. 
Если нет, уменьшаем число на 1 и пробуем еще один раз 
(вызываем метод снова на уменьшенное число). Теперь уже пишем получилось у нас или нет в консоль.*/
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
namespace C__training
{
    class Program
    {
        /*1) метод, в которые передается массив чисел и число, 
        если при добавлении данного числа к элементу массива получается число больше 10, 
        элемент удаляется из массива.
        */
        static void Task1()

        {

            var rand = new Random();
            int[] numbers;
            numbers = new int[10];
            var b = new int[numbers.Length];
            int addedNumber = 5;
            bool isZero;
            Console.WriteLine("Elements before deletion: ");
            foreach (int i in numbers)
            {
                if (numbers[i] >= 10)
                {
                    isZero = true;
                }
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 10);
                numbers[i] = numbers[i] + addedNumber;
                Console.WriteLine("Element[" + (i) + "]: " + numbers[i]);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 10)
                {
                    numbers[i] = 0;
                }
            }


            Console.WriteLine("\n");

            Console.WriteLine("Elements after deletion: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Element[" + (i + 1) + "]: " + numbers[i]);
            }
        }
        // 2) Метод который выводит поздравление с днем рождения в консоль, имя человека передается в метод
        static void Task2()
        {
            string name;
            double TodayDate = 3.01;
            Console.WriteLine("Введите ваше имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Я вас категорически приветствую " + name);
            Console.WriteLine("Введите вашу дату рождения: ");
            double BdayDate = Convert.ToDouble(Console.ReadLine());
            if (TodayDate == BdayDate)
            {
                Console.WriteLine("С днём рождения, человяк по имени " + name + "Твой день рождения " + BdayDate);
            }
            else
            {
                Console.WriteLine("Раз у тебя не др, досвидания");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Task1();
            Task2();
        }
    }
}
