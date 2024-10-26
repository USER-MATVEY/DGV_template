using DataGrid.Standart.Contracts.Models;
using System;

namespace training_task1
{
    internal class DataGenerator
    {
        public static Person CreatePerson(Action<Person> settings = null)
        {
            var person = new Person
            {
                Id = Guid.NewGuid(),
                BirthDate = DateTime.Now.AddYears(-16),
                Name = "JOja",
                AvrMark = 3.0m,
                Dept = false,
                Expelled = true,
                Gender = Gender.Male,
            };

            settings?.Invoke(person);
            return person;
        }
    }
}
