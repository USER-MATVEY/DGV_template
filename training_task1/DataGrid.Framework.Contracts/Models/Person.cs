using System;
using System.ComponentModel.DataAnnotations;

namespace DataGrid.Framework.Contracts.Models
{
    /// <summary>
    /// Класс студента.
    /// </summary>
    public class Person
    {
        public Guid Id { get; set; }

        /// <summary>
        /// ФИО студента.
        /// </summary>
        [Required]
        [StringLength(50, MinimumLength = 6)]
        public string Name { get; set; }

        /// <inheritdoc cref="Models.Gender"/>
        public Gender Gender { get; set; }

        /// <summary>
        /// Признак - отчисление.
        /// </summary>
        public bool Expelled { get; set; }

        /// <summary>
        /// Признак - задолженость
        /// </summary>
        public bool Dept { get; set; }

        /// <summary>
        /// Средний балл
        /// </summary>
        [Range(0, 5)]
        public decimal AvrMark { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime BirthDate { get; set; }
    }
}
