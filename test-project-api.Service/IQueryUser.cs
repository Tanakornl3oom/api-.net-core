using System;
using System.Collections.Generic;
using test_project_api.Entity.models;

namespace test_project_api.Service
{
    public interface IQueryUser
    {
        IEnumerable<User> getUsers();
        void addUser(string name);
        User getUserById(int id);
        User updateUser(int id,string name);
        User deleteUser(int id);
    }
}
