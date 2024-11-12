using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task_1
            //a)
            //Console.WriteLine("Введите ваше имя:");
            //string name = Console.ReadLine();
            //Console.WriteLine($"{name}");
            //Console.ReadKey();
            //b)
            //Console.WriteLine("Введите ваше имя:");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Привет, {name}!");
            //Console.ReadKey();

            //task_2
            //Console.WriteLine("Введите название футбольной команды:");
            //string teamName = Console.ReadLine();
            //Console.WriteLine($"{teamName} — это чемпион!");
            //Console.ReadKey();

            //task_3
            //Console.WriteLine("Введите имя:");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("Введите фамилию:");
            //string lastName = Console.ReadLine();
            //Console.WriteLine($"Полное имя: {firstName} {lastName}");
            //Console.ReadKey();

            //task_4
            //Console.WriteLine("Введите название государства:");
            //string country = Console.ReadLine();
            //Console.WriteLine("Введите название столицы:");
            //string capital = Console.ReadLine();
            //Console.WriteLine($"Столица государства {country} — город {capital}");
            //Console.ReadKey();

            //task_5
            //Console.WriteLine("Введите название романа:");
            //string bookTitle = Console.ReadLine();
            //Console.WriteLine("Введите фамилию автора:");
            //string authorLastName = Console.ReadLine();
            //Console.WriteLine($"Писатель {authorLastName} — автор романа {bookTitle}");
            //Console.ReadKey();

            //task_6
            //Console.WriteLine("Введите название футбольного клуба:");
            //string clubName = Console.ReadLine();
            //int count = clubName.Length;
            //Console.WriteLine($"В названии клуба {clubName} {count} символов.");
            //Console.ReadKey();

            //task_7
            //диалог_1
            //Console.WriteLine("Ты вчера был болен.");
            //Console.WriteLine("Измерь-ка температуру!");
            //Console.WriteLine("Сообщи, какая у тебя температура:");
            //double temperature = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"Ты {(temperature >= 36.6 ? "здоров, дружок!" : "не совсем здоров. Лучше останься дома.")}");
            //Console.WriteLine((temperature >= 36.6 ? "Можешь идти в школу." : ""));
            //Console.WriteLine("Желаю успехов!");
            //Console.ReadKey();

            //task_8
            //Console.WriteLine("Здравствуй, я компьютер, а тебя как зовут?");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Очень приятно, {name}.");
            //Console.WriteLine("Сколько тебе лет?");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Ого! Целых {age} лет! Ты уже совсем взрослый!");
            //Console.ReadKey();

            //task_9
            //Console.WriteLine("Как тебя зовут?");
            //string name2 = Console.ReadLine();
            //Console.WriteLine($"Привет, {name2}!");
            //Console.WriteLine("Сколько тебе лет?");
            //int age2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Какой у тебя любимый предмет в техникуме?");
            //string subject = Console.ReadLine();
            //Console.WriteLine("Какая у тебя любимая книга?");
            //string book = Console.ReadLine();
            //Console.WriteLine($"Значит тебя зовут, {name2}.");
            //Console.WriteLine($"Тебе {age2} лет.");
            //Console.WriteLine($"Твой любимый предмет -  {subject}.");
            //Console.WriteLine($"И твоя любимая книга – {book}");
            //Console.ReadKey();

            //task_10
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите возраст:");
            int age = Convert.ToInt32(Console.ReadLine());
            int birthYear = 2009 - age;
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Год рождения: {birthYear}");
            Console.ReadKey();
        }
    }
}
