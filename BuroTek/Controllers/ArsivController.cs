using AutoMapper;
using BuroTek.Entities.Dtos;
using BuroTek.Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace BuroTek.Controllers
{
    [ApiController]
    [Route("api[controller]")]
    public class ArsivController : ControllerBase
    {
        
            private readonly BuroContext _db;
            private readonly IMapper _autoMapper;
            private ActionResult<List<ArsivResponseModel>> arsivResponseModel;
            private object _Dbcontext;

            public ArsivController(BuroContext db)
            {
                _db = db;
            }
            [HttpGet]
            public ActionResult<List<ArsivResponseModel>> Get()
            {
                List<ArsivResponseModel> ArsivResponseModel = new List<ArsivResponseModel>();
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

            //Ahmet was here

        }
    }
    

