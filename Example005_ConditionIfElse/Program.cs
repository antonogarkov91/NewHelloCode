﻿Console.Write("введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "mary")
{
    Console.WriteLine("Ура, это же МАША");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}