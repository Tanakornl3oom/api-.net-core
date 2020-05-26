using System.Collections.Generic;
using test_project_api.Entity.models;

namespace test_project_api.Repositores
{
    public interface IRoleRepository
    {
        IEnumerable<Role> GetAll();
        Role Get(int id);
        Role Add(string name);
        Role Update(string name);
        Role Delete(int id);
    }
}