using AutoMapper;
using BuroTek.Dtos;
using BuroTek.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuroTek.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EvrakController : ControllerBase
    {
        private readonly BuroContext _db;
        private readonly IMapper _autoMapper;
        private ActionResult<List<EvrakResponseModel>> evrakResponseModel;
        private object _Dbcontext;

        public EvrakController(BuroContext db)
        {
            _db = db;
        }
        [HttpGet]
        public ActionResult<List<EvrakResponseModel>> Get()
        {
            List<EvrakResponseModel> evrakResponseModel = new List<EvrakResponseModel>();
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
