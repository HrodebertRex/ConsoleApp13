using System.ComponentModel.Design;

class Programm
{
    static void Main(string[] args)
    {
        int age;

        Console.WriteLine("Введите возраст пользователя");

        age = int.Parse(Console.ReadLine());

        if (age <= 17)
        {
            Console.WriteLine($"{age}...да ты ещё пездюк >.<");
        }
        else if (age >= 18 && age <= 100)
        {
            Console.WriteLine("Добро пожаловать!");
        }
        else 
        {
            Console.WriteLine("Столько не живут UwU");
        }


    }
}