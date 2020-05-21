using System.Collections.Generic;
using test_project_api.Enitity.models;

namespace test_project_api.Repositores
{
    public interface RoleIRepository
    {
        IEnumerable<Role> GetAll();
        Role Get(int id);
        Role Add(string name);
        Role Update(string name);
        Role Delete(int id);
    }
}