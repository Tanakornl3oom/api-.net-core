

using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Microsoft.EntityFrameworkCore;
using test_project_api.Entity;
using test_project_api.Entity.models;


namespace test_project_api.Repositores
{
    public class UserRepository : IUserRepository
    {
        private UserContext context;

        public UserRepository() 
        {
            context = new UserContext();
        }

        public void Add(string name)
        {
            using (var connection = DatabaseContext.Instance)
            {
                var result = connection.Execute("insert into users (name) values (@Name)", new { Name = name });
                Console.WriteLine("user: {0}", result);

            }


            //User user = new User();
            //user.Name = name;

            //context.Entry(user).State = EntityState.Added;
            //context.SaveChanges();
            //return user;
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
            using (var connection = DatabaseContext.Instance)
            {
                return connection.QuerySingleOrDefault<User>("select * from users where users.id=@Id", new { Id = id });
            }
            //return context.users.Find(id);
        }

        public IEnumerable<User> GetAll()

        {
            using (var connection = DatabaseContext.Instance)
            {   
                return connection.Query<User>("select * from users");
            }
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