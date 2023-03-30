// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// bool Palindrom(int n)
// {
//     int nConst = n;
//     int nNew = 0;
//     while (n > 0)
//     {
//         int lastDigit = n % 10;
//         nNew = nNew * 10 + lastDigit;
//         n = n / 10;
//     }
//     if (nNew == nConst)
//         return true;
//     else return false;
// }

// Console.WriteLine("Введите любое целое число: ");
// int x = Convert.ToInt32(Console.ReadLine());

// if (Palindrom(x) == true)
//     Console.WriteLine("Число является палиндромом.");
// else Console.WriteLine("Число не является палиндромом.");