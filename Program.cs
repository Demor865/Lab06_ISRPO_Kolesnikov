// // // // // using System;

// // // // // namespace Lab06
// // // // // {
// // // // //     class Program
// // // // //     {
// // // // //         static void Main(string[] args)
// // // // //         {
// // // // //             Console.WriteLine("    Задание 1.1    ");
// // // // //             for (int i = 10; i >= 1; i--)
// // // // //             {
// // // // //                 Console.WriteLine(i);
// // // // //             }

// // // // //             Console.WriteLine();
// // // // //             Console.WriteLine("    Задание 1.2    ");
// // // // //             for (int i = 2; i <= 50; i += 2)
// // // // //             {
// // // // //                 Console.WriteLine(i);
// // // // //             }
// // // // //         }
// // // // //     }
// // // // // }


// // // // using System;

// // // // namespace Lab06
// // // // {
// // // //     class Program
// // // //     {
// // // //         static void Main(string[] args)
// // // //         {
// // // //             int sum = 0;
// // // //             int count = 0;

// // // //             for (int i = 1; i <= 100; i++)
// // // //             {
// // // //                 if (i % 3 == 0)
// // // //                 {
// // // //                     sum += i;
// // // //                 }
// // // //                 if (i % 7 == 0)
// // // //                 {
// // // //                     count++;
// // // //                 }
// // // //             }

// // // //             Console.WriteLine($"Сумма чисел, кратных 3: {sum}");
// // // //             Console.WriteLine($"Количество чисел, кратных 7: {count}");
// // // //         }
// // // //     }
// // // // }


// // // using System;

// // // namespace Lab06
// // // {
// // //     class Program
// // //     {
// // //         static void Main(string[] args)
// // //         {
// // //             int positiveCount = 0;
// // //             int negativeCount = 0;

// // //             Console.Write("Введите число (0 для выхода): ");
// // //             int number = Convert.ToInt32(Console.ReadLine());

// // //             while (number != 0)
// // //             {
// // //                 if (number > 0)
// // //                 {
// // //                     positiveCount++;
// // //                 }
// // //                 else if (number < 0)
// // //                 {
// // //                     negativeCount++;
// // //                 }

// // //                 Console.Write("Введите число (0 для выхода): ");
// // //                 number = Convert.ToInt32(Console.ReadLine());
// // //             }

// // //             Console.WriteLine($"Положительных чисел: {positiveCount}");
// // //             Console.WriteLine($"Отрицательных чисел: {negativeCount}");
// // //         }
// // //     }
// // // }


// // using System;

// // namespace Lab06
// // {
// //     class Program
// //     {
// //         static void Main(string[] args)
// //         {
// //             bool isPasswordCorrect = false;

// //             for (int i = 1; i <= 3; i++)
// //             {
// //                 Console.Write("Введите пароль: ");
// //                 string password = Console.ReadLine();

// //                 if (password == "qwerty")
// //                 {
// //                     Console.WriteLine("Доступ разрешён");
// //                     isPasswordCorrect = true;
// //                     break;
// //                 }
// //             }

// //             if (isPasswordCorrect == false)
// //             {
// //                 Console.WriteLine("Доступ заблокирован");
// //             }
// //         }
// //     }
// // }


// using System;

// namespace Lab06
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("    Задание 5    ");
//             Console.Write("Введите число n (от 1 до 9): ");
//             int n = Convert.ToInt32(Console.ReadLine());

//             for (int i = 1; i <= 10; i++)
//             {
//                 Console.WriteLine($"{n} x {i} = {n * i}");
//             }

//             Console.WriteLine();
//             Console.WriteLine("    Задание 6    ");
//             for (int i = 1; i <= 30; i++)
//             {
//                 if (i % 3 == 0)
//                 {
//                     continue;
//                 }
//                 if (i % 10 == 0 && i > 20)
//                 {
//                     break;
//                 }

//                 Console.Write(i + " ");
//             }

//             Console.WriteLine();
//         }
//     }
// }


using System;

namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    Игра «Угадай число»     ");
            int secret = 42;
            bool guessed = false;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Попытка {i}. Введите число: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == secret)
                {
                    Console.WriteLine($"Победа! Попыток: {i}");
                    guessed = true;
                    break;
                }
                else if (guess > secret)
                {
                    Console.WriteLine("Меньше");
                }
                else
                {
                    Console.WriteLine("Больше");
                }
            }

            if (guessed == false)
            {
                Console.WriteLine($"Вы проиграли, число было {secret}");
            }

            Console.WriteLine();

            Console.WriteLine("    Доп. задание: Сумма и количество цифр    ");
            Console.Write("Введите целое положительное число: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int temp = num;
            int sum = 0;
            int count = 0;

            while (temp > 0)
            {
                sum += temp % 10;
                count++;
                temp = temp / 10;
            }

            Console.WriteLine($"Сумма цифр числа {num}: {sum}");
            Console.WriteLine($"Количество цифр: {count}");
        }
    }
}