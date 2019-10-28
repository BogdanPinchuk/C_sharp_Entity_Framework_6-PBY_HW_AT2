﻿using LesApp0.Context;
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
                db.DaysOfWeek.Load();
                db.Audiences.Load();
                //db.Trainers.Load();
                db.Specialities.Load();
                db.Groups.Load();

                // виведення груп
                //foreach (var g in db.Groups.Local)
                //{
                //    Console.WriteLine("\n" + g.ToString());
                //}

                foreach (var s in db.Specialities.Local)
                {
                    Console.WriteLine("\n" + s.ToString());
                    foreach (var t in s.Trainers)
                    {
                        Console.WriteLine("\n" + t.ToString());
                    }
                }

                Console.WriteLine(new string('-', 80));

                foreach (var t in db.Trainers)
                {
                    Console.WriteLine("\n" + t.ToString());
                    foreach (var s in t.Specialities)
                    {
                        Console.WriteLine("\n" + s.ToString());
                    }
                }
            }

            // delay
            Console.ReadKey(true);
        }
    }
}
