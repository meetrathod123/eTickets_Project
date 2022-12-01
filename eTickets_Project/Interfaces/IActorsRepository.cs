using eTickets_Project.Models;

namespace eTickets_Project.Interfaces
{
    //This interface is use to deal with data, insted of controller, interface is good practice to make it.

    public interface IActorsRepository
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIDAsync(int id); //Get by id
        Task AddAsync(Actor actor); //Post request
        Task<Actor> UpdateAsync(int id, Actor newActor);//Update data, here id is to get id from db and newActor is user input data which will match.
        Task DeleteAsync(int id);
        bool Save();
    }
}
