using AutoMapper;
using BuroTek.Dtos;
using BuroTek.Mapper;
using BuroTek.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BuroTek.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly BuroContext _db;
        private readonly IMapper _autoMapper;
        private ActionResult<List<NotlarResponseModel>> userResponseModel;
        private object _Dbcontext;

        public UsersController(BuroContext db)
        {
            _db = db;
        }
        [HttpGet]
        public ActionResult<List<UserResponseModel>> Get()
        {
            List<UserResponseModel> userResponseModel = new List<UserResponseModel>();
            var result = _db.users.ToList();
            if (result.Any())
            {
                return Ok(result);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Notlar todo)
        {
            _db.Notlar.Add(todo);
            await _db.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Notlar todo)
        {
            var existingTodo = _db.users.FirstOrDefault(t => t.UserId == id);
            if (existingTodo == null)
            {
                return NotFound();
            }

            existingTodo.AdSoyad = todo.AdSoyad;


            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var todo = _db.users.FirstOrDefault(t => t.UserId == id);
            if (todo == null)
            {
                return NotFound();
            }

            _db.users.Remove(todo);

            return NoContent();
        }



    }

}






