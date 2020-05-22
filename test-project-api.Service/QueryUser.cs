
using System.Collections.Generic;
using test_project_api.Enitity.models;
using test_project_api.Repositores;

namespace test_project_api.Service
{
    public class QueryUser : IQueryUser
    {

    private readonly UserIRepository _userIRepository;

    public QueryUser(UserIRepository userIRepository)
        {
            _userIRepository = userIRepository;
        }

        public User addUser(string name)
        {
            return _userIRepository.Add(name);
        }

        public User deleteUser(int id)
        {
            return _userIRepository.Delete(id);
        }

        public User getUserById(int id)
        {
            return _userIRepository.Get(id);
        }

        public IEnumerable<User> getUsers()
        {
            return _userIRepository.GetAll();
        }

        public User updateUser(int id,string name)
        {
            return _userIRepository.Update(id , name);
        }
    }
}