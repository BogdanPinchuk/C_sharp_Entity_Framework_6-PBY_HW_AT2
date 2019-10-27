using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0.Models
{
    /// <summary>
    /// Тренер
    /// </summary>
    public class Trainer
    {
        /// <summary>
        /// Тип тренера
        /// </summary>
        public enum TypeTrainer
        {
            /// <summary>
            /// Головний тренер
            /// </summary>
            Main,
            /// <summary>
            /// Помічник тренера
            /// </summary>
            Assistant,
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
        /// Тип тренера
        /// </summary>
        public TypeTrainer Type { get; set; }

        /// <summary>
        /// Спеціальності, які викладає тренер
        /// </summary>
        public ICollection<Speciality> Specialities { get; set; }

        public Trainer()
        {
            Specialities = new List<Speciality>();
        }

        public override string ToString()
            => $"{Type.ToString()} - {FullName}";
    }
}
