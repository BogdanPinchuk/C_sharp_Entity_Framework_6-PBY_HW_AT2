using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0.Models
{
    /// <summary>
    /// Дні тижня
    /// </summary>
    public class WeekDays
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// День тижня
        /// </summary>
        public DayOfWeek DaysOfWeek { get; set; }
        /// <summary>
        /// Група
        /// </summary>
        public Group Group { get; set; }

        public override string ToString()
            => DaysOfWeek.ToString();
    }
}
