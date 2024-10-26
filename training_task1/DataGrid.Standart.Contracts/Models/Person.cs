using System;

namespace DataGrid.Standart.Contracts.Models
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
        public decimal AvrMark { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime BirthDate { get; set; }
    }
}
