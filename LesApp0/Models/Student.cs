using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0.Models
{
    /// <summary>
    /// Студент
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Тип присутності студента
        /// </summary>
        public enum TypeStudent
        {
            /// <summary>
            /// Вживу
            /// </summary>
            Live,
            /// <summary>
            /// Онлайн
            /// </summary>
            Online
        }

        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// ПІБ
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Тип студента
        /// </summary>
        public TypeStudent Type { get; set; }
        /// <summary>
        /// Група в якій навчається студент
        /// </summary>
        public Group Group { get; set; }

        public override string ToString()
            => $"{Type.ToString()} - {FullName}";

    }
}
