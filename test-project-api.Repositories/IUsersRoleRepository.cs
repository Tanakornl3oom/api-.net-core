using System.Collections.Generic;
using test_project_api.Entity.models;

namespace test_project_api.Repositores
{ 
    public interface IUsersRoleRepository
    {
        IEnumerable<UsersRole> GetAll();
        UsersRole Get(int id);
        UsersRole Add(string name);
        UsersRole Update(string name);
        UsersRole Delete(int id);
    }
}