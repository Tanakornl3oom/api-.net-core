﻿
using System;
using System.Collections.Generic;
using test_project_api.Entity.models;
using test_project_api.Repositores;

namespace test_project_api.Service
{
    public class QueryUser : IQueryUser
    {

    private readonly IUserRepository _userRepository;

    public QueryUser(IUserRepository userIRepository)
        {
            _userRepository = userIRepository;
        }

        public void addUser(string name)
        {
            _userRepository.Add(name);
        }

        public int deleteUser(int id)
        {
            var result = _userRepository.Delete(id);
            if (result == 1)
            {
                return id;
            }else
            {
                throw new Exception("delete user id : "+id+" fail");
            }
        }

        public User getUserById(int id)
        {
            var user = _userRepository.Get(id);
            if (user == null)
            {
                throw new ArgumentException("user id not forund");
            }
            return user;
        }

        public IEnumerable<User> getUsers()
        {
            return _userRepository.GetAll();
        }

        public User updateUser(int id,string name)
        {
            return _userRepository.Update(id , name);
        }
    }
}