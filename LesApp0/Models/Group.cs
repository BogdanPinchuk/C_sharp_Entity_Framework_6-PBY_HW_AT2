﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0.Models
{
    /// <summary>
    /// Група
    /// </summary>
    public class Group
    {
        public enum FormLearning
        {
            /// <summary>
            /// Очна
            /// </summary>
            FullTime,
            /// <summary>
            /// Заочна (онлайн)
            /// </summary>
            External,
        }

        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Кількість студентів у групі
        /// </summary>
        public int Count
            => Students.Count;
        /// <summary>
        /// Курс
        /// </summary>
        public string Course { get; set; }
        /// <summary>
        /// Форма навчання
        /// </summary>
        public FormLearning Form { get; set; }

        /// <summary>
        /// Час початку занять
        /// </summary>
        public DateTime Date { get; set; }
        // Примітка. Зазвичай в даному випадку важливий лише час початку занять,
        // але даний тип враховує і день.місяць.рік - отже сюди можна записати
        // день початку першого заняття, таким чином вбиваємо одним ударом двох заців

        /// <summary>
        /// Розклад - по яких днях відбуваються занняття
        /// </summary>
        public ICollection<WeekDays> TimeTable { get; set; }

        /// <summary>
        /// Спеціальності і курси по якій навчаєтсья група
        /// </summary>
        public ICollection<Speciality> Specialities { get; set; }
        /// <summary>
        /// Студенти які навчаються в групі
        /// </summary>
        public ICollection<Student> Students { get; set; }

        public Group()
        {
            Students = new List<Student>();
            TimeTable = new List<WeekDays>();
            Specialities = new List<Speciality>();
        }

        public override string ToString()
        {
            var s = new StringBuilder($"Group for {Course} with {Form} studing,\n" +
                $"\thas {Count} students,\n" +
                $"\tstarted learning {Date.ToShortDateString()},\n" +
                $"\ttraining: ");
            
            foreach (var i in TimeTable)
            {
                s.Append(i.ToString() + ", ");
            }

            s.Append($"from {Date.ToShortTimeString()} to {Date.AddHours(2).ToShortTimeString()}");

            return s.ToString();
        }

    }

}
