
using System;
using System.Collections.Generic;
using test_project_api.Entity.models;
using test_project_api.Repositores;

namespace test_project_api.Service
{
    public class QueryUser : IQueryUser
    {

    private readonly IUserRepository _iUserRepository;

    public QueryUser(IUserRepository userIRepository)
        {
            _iUserRepository = userIRepository;
        }

        public User addUser(string name)
        {
            return _iUserRepository.Add(name);
        }

        public User deleteUser(int id)
        {
            return _iUserRepository.Delete(id);
        }

        public User getUserById(int id)
        {
            var user = _iUserRepository.Get(id);
            if (user == null)
            {
                throw new ArgumentException("user id not forund");
            }
            return user;
        }

        public IEnumerable<User> getUsers()
        {
            return _iUserRepository.GetAll();
        }

        public User updateUser(int id,string name)
        {
            return _iUserRepository.Update(id , name);
        }
    }
}