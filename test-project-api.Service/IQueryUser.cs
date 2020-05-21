using System;
using System.Collections.Generic;
using test_project_api.Enitity.models;

namespace test_project_api.Service
{
    public interface IQueryUser
    {
        IEnumerable<User> getUsers();
        User addUser(string name);
    }
}
