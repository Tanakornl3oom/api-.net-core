

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using test_project_api.Enitity;
using test_project_api.Enitity.models;

namespace test_project_api.Repositores
{
    public class UserRepository : UserIRepository
    {
        private UserContext context;

        public UserRepository(UserContext context) 
        {
            this.context = context;
        }

        public User Add(string name)
        {
            User user = new User();
            user.Name = name;

            context.Entry(user).State = EntityState.Added;
            context.SaveChanges();
            return user;
        }

        public User Delete(int id)
        {
            User user = context.users.Find(id);
            context.Entry(user).State = EntityState.Deleted;
            context.SaveChanges();
            return user;
        }

        public User Get(int id)
        {
            return context.users.Find(id);
        }

        public IEnumerable<User> GetAll()
        {
            return context.users.AsEnumerable();
        }

        public User Update(int id ,string name)
        {
            User user = context.users.Find(id);
            user.Name = name;

            context.Entry(user).State = EntityState.Modified;
            context.SaveChanges();
            return user;

        }
    }
}