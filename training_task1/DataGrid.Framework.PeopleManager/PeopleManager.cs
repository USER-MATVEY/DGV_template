using DataGrid.Framework.PeopleManager.Models;
using DataGrid.Standart.Contracts;
using DataGrid.Standart.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGrid.Standart.PeopleManager
{
    public class PeopleManager : IPeopleManager
    {
        private IPeopleStorage peopleStorage;

        public PeopleManager(IPeopleStorage peopleStorage)
        {
            this.peopleStorage = peopleStorage;
        }

        public async Task<Person> AddAsync(Person person)
        {
            //
            var rasult = await peopleStorage.AddAsync(person);
            //
            return rasult;
        }

        public async Task<bool> deleteAsync(Guid id)
        {
            //
            var result = await peopleStorage.deleteAsync(id);
            //
            return result;
        }

        public Task EditAsync(Person person)
            => peopleStorage.EditAsync(person);

        public Task<IReadOnlyCollection<Person>> GetAllAsync()
            => peopleStorage.GetAllAsync();

        public async Task<IPeopleStats> GetAllStatsAsync()
        {
            var result = await peopleStorage.GetAllAsync();
            return new IPeopleStatsModel
            {
                Count = result.Count,
                MaleCount = result.Where(x => x.Gender == Gender.Male).Count(),
                FemaleCount = result.Where(x => x.Gender == Gender.Female).Count(),
                ExpelledCount = result.Where(x => x.Expelled).Count(),
                DeptCount = result.Where(x => x.Dept).Count(),
                AvrRate = result.DefaultIfEmpty(new Person()).Average(x => x.AvrMark),
            };
        }
    }
}
