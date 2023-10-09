using AutoMapper;
using BuroTek.Entities.Dtos;
using BuroTek.Entities.Entities.Dtos;
using BuroTek.Entities.Models;
using BuroTek.WorkPlace.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BuroTek.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _userService.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        [HttpGet("getbyid")]
        public IActionResult Get(string TcNo)
        {
            var result = _userService.GetById(TcNo);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult post(User user)
        {
            var result = _userService.Add(user);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }    
    }

}






