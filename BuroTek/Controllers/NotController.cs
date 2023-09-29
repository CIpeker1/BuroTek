using AutoMapper;
using BuroTek.Dtos;
using BuroTek.Model;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class NotController : ControllerBase
{
    private readonly List<Notlar> _todos;
    private readonly BuroContext _db;
    private readonly IMapper _autoMapper;
    public NotController(BuroContext db, IMapper mapper)
    {
        _db = db;
        _autoMapper = mapper;
        _todos = new List<Notlar>();
    }

    [HttpGet]
    public ActionResult<List<NotlarResponseModel>> Get()
    {
        List<NotlarResponseModel> todoResponseModel = new List<NotlarResponseModel>();
        var result = _db.Notlar.Where(x=> x.Id > 0).OrderByDescending(x => x.Id).ToList();

        var a = _autoMapper.Map<List<NotlarResponseModel>>(result);

        return a;
    }

    [HttpGet("{id}")]
    public ActionResult<Notlar> GetById(int id)
    {
        var todo = _todos.FirstOrDefault(t => t.Id == id);
        if (todo == null)
        {
            return NotFound();
        }
        return todo;
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
        var existingTodo = _todos.FirstOrDefault(t => t.Id == id);
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
        var todo = _todos.FirstOrDefault(t => t.Id == id);
        if (todo == null)
        {
            return NotFound();
        }

        _todos.Remove(todo);

        return NoContent();
    }
}
