using System.Collections.Generic;
using test_project_api.Enitity.models;

namespace test_project_api.Repositores 
{
    public interface UserIRepository
    {
        IEnumerable<User> GetAll();
        User Get(int id);
        User Add(string name);
        User Update(int id ,string name);
        User Delete(int id);
    }
}