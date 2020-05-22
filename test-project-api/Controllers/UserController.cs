using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using test_project_api.Enitity.models;
using test_project_api.Service;
using test_project_api.RequestObject;

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
        public IEnumerable<User> Get()
        {

            return _IQueryUser.getUsers();
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _IQueryUser.getUserById(id);
        }

        [HttpPost]
        public User AddUser(UserRequestDto request)
        {

            return _IQueryUser.addUser(request.name);
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
