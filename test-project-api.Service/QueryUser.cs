
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

        public IEnumerable<User> getUsers()
        {
            return _userIRepository.GetAll();
        }
    }
}