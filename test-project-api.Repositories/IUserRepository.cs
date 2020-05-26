using System.Collections.Generic;
using test_project_api.Entity.models;

namespace test_project_api.Repositores 
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User Get(int id);
        User Add(string name);
        User Update(int id ,string name);
        User Delete(int id);
    }
}