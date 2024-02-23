using Microsoft.AspNetCore.Mvc;
using ToDoAPI.Data.Models;
using ToDoAPI.Data.Repositories;

namespace ToDoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoRepository _repo;

        public ToDoController(IToDoRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IEnumerable<ToDo>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ToDo?> GetByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }
    }
}
