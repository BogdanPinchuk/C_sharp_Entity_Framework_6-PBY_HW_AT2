using LesApp0.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0.Context
{
    /// <summary>
    /// Контекст
    /// </summary>
    public class ITContext : DbContext
    {
        static ITContext()
        {
            Database.SetInitializer(new ContextInitializer());
        }

        public ITContext()
            :base("ITConnection") { }

        /// <summary>
        /// Групи
        /// </summary>
        public virtual DbSet<Group> Groups { get; set; }
        /// <summary>
        /// Дні тижня
        /// </summary>
        public virtual DbSet<WeekDays> DaysOfWeek { get; set; }
        /// <summary>
        /// Аудиторії
        /// </summary>
        public virtual DbSet<Audience> Audiences { get; set; }
        /// <summary>
        /// Тренера
        /// </summary>
        public virtual DbSet<Trainer> Trainers { get; set; }
        /// <summary>
        /// Спеціальності
        /// </summary>
        public virtual DbSet<Speciality> Specialities { get; set; }
        /// <summary>
        /// Студенти
        /// </summary>
        public virtual DbSet<Student> Students { get; set; }

    }
}
