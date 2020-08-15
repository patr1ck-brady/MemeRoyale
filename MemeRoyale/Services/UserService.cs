using MemeRoyale.Data;
using MemeRoyale.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemeRoyale.Services
{
    public interface IUserService
    {

    }

    public class UserService : IUserService
    {
        private readonly MemeRoyaleContext _database;

        public UserService(MemeRoyaleContext database)
        {
            _database = database;
        }

        public async Task<User> GetById(int userId)
        {
            var user = _database.Users.Where(u => u.Id == userId).FirstOrDefault();


        }

        public async Task<User> AddUser(Guid roomId, string name, string avatarUrl)
        {
            // Get the room


            var user = new User
            {
                Name = name,
                AvatarUrl = avatarUrl
                Room = 
            };

            _database.Users.Add(user);
            _database.SaveChanges();

            return user;
        }
    }
}
