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

        [HttpPost]
        public User AddUser(UserRequestDto request)
        {

            return _IQueryUser.addUser(request.name);
        }
    }
}
