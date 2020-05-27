using System.Collections.Generic;
using test_project_api.Entity.models;

namespace test_project_api.Repositores 
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User Get(int id);
        void Add(string name);
        User Update(int id ,string name);
        int  Delete(int id);
    }
}