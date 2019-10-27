using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0.Models
{
    /// <summary>
    /// Аудиторія
    /// </summary>
    public class Audience
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Номер аудиторії
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Категорія
        /// </summary>
        public string Category { get; set; }

        ///// <summary>
        ///// Спеціальність, яка закріплена за даною аудиторією
        ///// </summary>
        //public Speciality Speciality { get; set; }

        public override string ToString()
            => $"Audience № {Number}{((Category !=  " ") ? $"-{Category}" : string.Empty)}";

    }
}
