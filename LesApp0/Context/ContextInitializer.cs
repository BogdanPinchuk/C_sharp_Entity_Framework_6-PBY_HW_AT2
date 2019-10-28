using LesApp0.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://metanit.com/sharp/entityframework/3.9.php

namespace LesApp0.Context
{
    /// <summary>
    /// Ініціаолізатор бази даних
    /// </summary>
    public class ContextInitializer : DropCreateDatabaseAlways<ITContext>
    {
        protected override void Seed(ITContext db)
        {
            #region створюємо аудиторії
            Audience[] audiences = new Audience[]
            {
                new Audience(){ Number = 511, Category = "a" },
                new Audience(){ Number = 501, Category = " " },
                new Audience(){ Number = 512, Category = "a" },
                new Audience(){ Number = 512, Category = "b" },
            };
            #endregion

            #region створюємо спеціальності
            Speciality[] specialities = new Speciality[]
            {
                new Speciality(){ Name = "C# Starter", Lessons = 9, Audience = audiences[0] },
                new Speciality(){ Name = "C# Esential", Lessons = 18, Audience = audiences[0] },
                new Speciality(){ Name = "C# Profesional", Lessons = 15, Audience = audiences[2] },
                new Speciality(){ Name = "SQL", Lessons = 7, Audience = audiences[1] },
                new Speciality(){ Name = "Entity Framework 6", Lessons = 5, Audience = audiences[2] },
                new Speciality(){ Name = "ASP.NET MVC Fundamentals", Lessons = 10, Audience = audiences[3] },
            };
            #endregion

            #region створюємо дні тижня
            WeekDays[] daysOfWeek = new WeekDays[]
            {
                new WeekDays() { DaysOfWeek = DayOfWeek.Monday },
                new WeekDays() { DaysOfWeek = DayOfWeek.Wednesday },
                new WeekDays() { DaysOfWeek = DayOfWeek.Friday },
            }; 
            #endregion

            #region створюємо групу
            Group group = new Group()
            {
                Course = "C#/.Net Developer",
                Count = 20,
                Form = Group.FormLearning.FullTime,
                TimeTable = daysOfWeek.ToList(),
                Date = new DateTime(2019, 06, 10, 19, 00, 00),
                Specialities = specialities,
            };
            #endregion

            #region створюємо тренерів // Примітка. Не враховується хто що знає, а враховується що було проведено в нашій групі
            Trainer[] trainers = new Trainer[]
            {
                new Trainer(){ FullName = "Vlad", Type = Trainer.TypeTrainer.Main,
                    Specialities = new List<Speciality>(){ specialities[0], specialities[1], specialities[2]} },
                new Trainer(){ FullName = "Dmitriy", Type = Trainer.TypeTrainer.Assistant,
                    Specialities = specialities.ToList() },
                new Trainer(){ FullName = "Yuriy", Type = Trainer.TypeTrainer.Main,
                    Specialities = new List<Speciality>(){ specialities[2]} },
                new Trainer(){ FullName = "Stanislav", Type = Trainer.TypeTrainer.Main,
                    Specialities = new List<Speciality>(){ specialities[3]} },
                new Trainer(){ FullName = "Roman", Type = Trainer.TypeTrainer.Main,
                    Specialities = new List<Speciality>(){ specialities[4], specialities[5]} },
            };
            #endregion

            // збереження даних
            db.DaysOfWeek.AddRange(daysOfWeek);
            db.Audiences.AddRange(audiences);
            db.Specialities.AddRange(specialities);
            db.Trainers.AddRange(trainers);
            db.Groups.Add(group);
            db.SaveChanges();
        }
    }
}
