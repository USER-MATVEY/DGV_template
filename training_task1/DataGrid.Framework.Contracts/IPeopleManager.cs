using DataGrid.Framework.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataGrid.Framework.Contracts
{
    public interface IPeopleManager
    {
        Task<IReadOnlyCollection<Person>> GetAllAsync();

        Task<Person> AddAsync(Person person);

        Task EditAsync(Person person);

        Task<bool> deleteAsync(Guid id);

        Task<IPeopleStats> GetAllStatsAsync();
    }
}
