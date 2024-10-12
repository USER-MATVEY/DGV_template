using DataGrid.Framework.Contracts;
using DataGrid.Framework.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGrid.Storage.Memory
{
    public class MemoryPeopleStorage : IPeopleStorage
    {
        private List<Person> people;

        public MemoryPeopleStorage()
        {
            people = new List<Person>();
        }

        public Task<Person> AddAsync(Person person)
        {
            people.Add(person);
            return Task.FromResult(person);
        }

        public Task<bool> deleteAsync(Guid id)
        {
            var person = people.FirstOrDefault(x => x.Id == id);
            if (person != null)
            {
                people.Remove(person);
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }

        public Task EditAsync(Person person)
        {
            var target = people.FirstOrDefault(x => x.Id == person.Id);
            if (target != null)
            {
                target.Name = person.Name;
                target.AvrMark = person.AvrMark;
                target.Gender = person.Gender;
                target.BirthDate = person.BirthDate;
                target.Dept = person.Dept;
                target.Expelled = person.Expelled;
            }
            return Task.CompletedTask;
        }

        public Task<IReadOnlyCollection<Person>> GetAllAsync()
            => Task.FromResult<IReadOnlyCollection<Person>>(people);
    }
}
