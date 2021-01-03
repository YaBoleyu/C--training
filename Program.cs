/*
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
        public int number;
        public string name;
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
            Console.WriteLine("Elements before deletion: ");
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
        // 2) Метод который выводит поздравление с днем рождения в консоль, имя человека передается в метод - done
        static void Task2(string name)
        {
            double TodayDate = 3.01;
            Console.WriteLine("Введите ваше имя: ");
            Console.WriteLine("Я вас категорически приветствую " + name);
            Console.WriteLine("Введите вашу дату рождения: ");
            double BdayDate = Convert.ToDouble(Console.ReadLine());
            if (TodayDate == BdayDate)
            {
                Console.WriteLine("С днём рождения, человяк по имени " + name + " Твой день рождения " + BdayDate);
            }
            else
            {
                Console.WriteLine("Др у тебя " + BdayDate + ", а сегодня " + TodayDate + " так шо, раз у тебя не др, досвидания");
            }

        }
        /*3) Метод который получает число, возвращает true, если это простое число. 
        В коде, если это оказалось простое число, выводим его в консоль, с надписью, что это простое число. 
        Если нет, уменьшаем число на 1 и пробуем еще один раз 
        (вызываем метод снова на уменьшенное число). Теперь уже пишем получилось у нас или нет в консоль. - done*/

        /* TO DO 
        1. В задаче один доделать нормальное удаление значений из массивов
        2. В задаче 2 понять почему на компиляторе VS CODE оно через хуй работает
        3. В задаче 3 разобраться с "c# возвращает ошибку «не все пути кода возвращают значение»"
        */
        public static bool Task3(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Это число натуральное: " + number);
                return true;

            }
            else
            {
                Console.WriteLine(number + "Это число  не является натуральным, поехали ещё раз: ");
                number = number - 1;
                Task3(number);
            }
            return false;

        }
        //1. Write a C# Sharp program to print Hello and your name in a separate line.
        public static void Task4(string name)
        {
            Console.WriteLine("Hello, " + name);
        }
        // Write a C# Sharp program to print the sum of two numbers
        public static void Task5(int n1, int n2)
        {
            int n3 = n1 + n2;
            Console.WriteLine(n1 + "+" + n2 + "=" + n3);
        }
        // Write a C# Sharp program to print the result of dividing two numbers
        public static void Task6(int n1, int n2)
        {
            int n3 = (n1 / n2);
            Console.WriteLine(n1 + "/" + n2 + "=" + n3);
        }
        // Write a C# Sharp program to print the result of the specified operations
        /*

        -1 + 4 * 6
        ( 35+ 5 ) % 7
        14 + -4 * 6 / 11
        2 + 15 / 6 * 1 - 7 % 2 
        
        */
        public static void Task7()
        {
            int n1; int n2; int n3; int n4;
            n1 = (-1 + 4 * 6);
            n2 = ((35 + 5) % 7);
            n3 = (14 - 4 * 6 / 11);
            n4 = (2 + 15 / 6 * 1 - 7 % 2);
            Console.WriteLine(Convert.ToString(n1) + ", " + Convert.ToString(n2) + ", " + Convert.ToString(n3) + ", " + Convert.ToString(n4));

        }
        //Write a C# Sharp program to swap two numbers
        public static void Task8()
        {
            int n1, n2, tmp;
            n1 = 21;
            n2 = 22;
            Console.WriteLine("First number before swap: " + n1);
            Console.WriteLine("Second number before swap: " + n2);
            tmp = n1;
            n1 = n2;
            n2 = tmp;
            Console.WriteLine("First number after swap: " + n1);
            Console.WriteLine("Second number after swap: " + n2);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Task1();
            //Task2(Console.ReadLine());
            //Task3(47);
            //Task4("NameTest");
            //Task5(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            //Task6(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            //Task7();
            //Task8();
        }
    }
}
