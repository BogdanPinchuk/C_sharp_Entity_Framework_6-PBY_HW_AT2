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
                db.Groups.Load();

                // виведення груп
                foreach (var g in db.Groups.Local)
                {
                    Console.WriteLine("\n" + g.ToString());
                }
            }

            // delay
            Console.ReadKey(true);
        }
    }
}
