using eTickets_Project.Data;
using eTickets_Project.Interfaces;
using eTickets_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets_Project.Repository
{
    public class ActorRepository : IActorsRepository
    {
        private readonly AppDbContext _context;
        public ActorRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Actor actor)

        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();  
        }

        public void Delete(Actor actor)
        {
            _context.Remove(actor);
            _context.SaveChanges(true);
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);    
            _context.Actors.Remove(result);
            await _context.SaveChangesAsync();
        }

       

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            return await _context.Actors.ToListAsync();
        }

        public async Task<Actor> GetByIDAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }

        
    }
}
