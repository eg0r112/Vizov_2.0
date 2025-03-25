using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    //ДОБАВИТЬ TRY CATCH  на int32
    public string Name;
    public int Age;
    delegate void Proverka();
    static string exePath = AppDomain.CurrentDomain.BaseDirectory;
    public string filePath;
    static void Main()
    {
        string filePath = (exePath + "users.txt");
        if (!File.Exists(filePath))
        {
            File.CreateText(filePath);
        }
        Program prog = new Program();
        Console.WriteLine("Введите ваше Имя");
        prog.Name = Console.ReadLine();
        Console.WriteLine("Введите ваш возраст");
        try
        {
            prog.Age = Int32.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Ошибка, введите возраст");
            Main();
        }
        if (prog.Name.Trim().Length == 0)
        {
            Console.WriteLine("Ошибка, введите имя");
            Main();
        }
        Proverka prov;
        prov = prog.OnUserCreated;
        prov();
    }


    //ДОБАВИТЬ TRY CATCH  на int32
    public void OnUserCreated()
    {
        Console.Clear();
        Console.WriteLine($"Зарегестрирован новый пользователь {Name}, {Age} лет");
        Thread.Sleep(3000);
        Console.Clear();
        Console.WriteLine($"Здравствуйте, {Name}!");
        if (Age>17)
        {
            string filePath = (exePath + "users.txt");
            string textToAppend = $"{Name}, {Age}";
            File.AppendAllText(filePath, textToAppend + Environment.NewLine);
        }
    }
}
     //ДОБАВИТЬ TRY CATCH   на int32
