using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using test_project_api.Entity.models;
using test_project_api.Service;
using test_project_api.RequestObject;
using Microsoft.AspNetCore.Http;

namespace test_project_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly IQueryUser _IQueryUser;

        public UserController(IQueryUser queryUser )

        {   
            _IQueryUser = queryUser;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return StatusCode(StatusCodes.Status200OK, _IQueryUser.getUsers()); 
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var user = _IQueryUser.getUserById(id);
               
                Console.WriteLine("user: {0} {1}", user, user == null);
                return StatusCode(StatusCodes.Status200OK, user);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }

        }

        [HttpPost]
        public IActionResult AddUser(UserRequestDto request)
        {
            try
            {
                _IQueryUser.addUser(request.name);
                return StatusCode(StatusCodes.Status201Created, "created user");
            }catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }

        }

        [HttpPut("{id}")]
        public User Update(int id, UserRequestDto request)
        {
            return _IQueryUser.updateUser(id,request.name);
        }

        [HttpDelete("{id}")]
        public User delete(int id)
        {
            return _IQueryUser.deleteUser(id);
        }
    }
}
