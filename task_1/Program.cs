﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.WriteLine("Введите пятизначное число: ");
string? number = Console.ReadLine();

{
  if (number[0]==number[4] || number[1]==number[3])
  
  {
    Console.WriteLine("да, это палиндром");
  }
  else Console.WriteLine("нет, это не палиндром");
}
