using DataGrid.Contracts.Models;

namespace DataGrid.Contracts
{
    public interface IPeopleManager
    {
        Task<IReadOnlyCollection<Person>> GetAllAsync();

        Task<Person> AddAsync(Person person);

        Task EditAsync(Person person);

        Task<bool> deleteAsync(Guid id);

        Task<PeopleStats> GetAllStatsAsync();
    }
}
