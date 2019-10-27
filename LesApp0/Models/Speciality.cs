using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0.Models
{
    /// <summary>
    /// Спеціальність
    /// </summary>
    public class Speciality
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Назва спеціальності
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Кількість занять
        /// </summary>
        public int Lessons { get; set; }

        /// <summary>
        /// Тренера, які викладають дані спеціальності
        /// </summary>
        public ICollection<Trainer> Trainers { get; set; }

        /// <summary>
        /// Аудиторія, закріплена за даною спеціальністю
        /// </summary>
        public Audience Audience { get; set; }

        /// <summary>
        /// Групи, які навчаються за даною спеціальністю
        /// </summary>
        public Group Group { get; set; }
        public Speciality()
        {
            Trainers = new List<Trainer>();
        }

        public override string ToString()
            => $"Speciality: {Name}, has {Lessons} lessons in {Audience.ToString()}";
    }
}
