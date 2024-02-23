using ToDoAPI.Data.Models;

namespace ToDoAPI.Data.Repositories
{
    public interface IToDoRepository
    {
        public Task<IEnumerable<ToDo>> GetAllAsync();
        public Task<ToDo?> GetByIdAsync(int id);
    }
}
