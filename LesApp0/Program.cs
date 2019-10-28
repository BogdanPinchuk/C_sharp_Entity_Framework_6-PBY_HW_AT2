using LesApp0.Context;
using LesApp0.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Щоб не сильно ускладнювати, реалізуємо всі можливі зв'язки за
// допомогою запропонованих моделей
// Спеціальність - Аудиторія: 1х1
// Група - Спеціальності: 1хM
// Група - Студенти: 1хM
// Тренера - Спеціальності: МхМ

namespace LesApp0
{
    class Program
    {
        static void Main()
        {
            // join unicode
            Console.OutputEncoding = Encoding.Unicode;

            // connect to DataBase
            using (ITContext db = new ITContext())
            {
                // завантаження даних
                db.DaysOfWeek.Load();
                db.Audiences.Load();
                db.Trainers.Load();
                db.Specialities.Load();
                db.Students.Load();
                db.Groups.Load();

                // виведення інформації
                foreach (var g in db.Groups.Local)
                {
                    Console.WriteLine("\n" + g.ToString());

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nСпеціальності:");
                    Console.ResetColor();

                    foreach (var s in g.Specialities)
                    {
                        // назва спеціальності
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n" + s.ToString());
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n\tТренера:");
                        Console.ResetColor();

                        foreach (var t in s.Trainers)
                        {
                            Console.WriteLine("\t" + t.ToString());
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nСтуденти групи:");
                    Console.ResetColor();

                    foreach (var s in g.Students)
                    {
                        Console.WriteLine("\t" + s.ToString());
                    }
                }

                Console.WriteLine("\n" + new string('-', 80));
            }

            // delay
            Console.ReadKey(true);
        }
    }
}
