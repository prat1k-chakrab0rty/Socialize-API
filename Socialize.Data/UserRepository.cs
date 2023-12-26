using Microsoft.EntityFrameworkCore;
using Socialize.Contracts.User;
using Socialize.Data.RepositoryInterface;
using Socialize.DB;
using Socialize.Domain.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socialize.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly SocializeContext _context;

        public UserRepository(SocializeContext context)
        {
            _context = context;
        }
        public async Task<List<User>> GetAll()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }
        public async Task<User> CreateOrUpdate(CreateOrUpdateUserReq req)
        {
            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.GoogleId == req.GoogleId || u.Email == req.Email);
            //new user
            if (existingUser == null)
            {
                var entity = new User
                {
                    Id = 0,
                    Address = req.Address,
                    Bio = req.Bio,
                    Email = req.Email,
                    FullName = req.FullName,
                    GoogleId = req.GoogleId,
                    PhotoURL = req.PhotoURL,
                    School = req.School,
                    CreatedBy = -1,
                    CreatedOn = DateTime.Now
                };
                await _context.Users.AddAsync(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            //existing user
            else
            {
                existingUser.FullName = req.FullName;
                existingUser.PhotoURL = req.PhotoURL;
                existingUser.Bio = req.Bio;
                existingUser.Address = req.Address;
                existingUser.School = req.School;
                existingUser.ModifiedBy = existingUser.Id;
                existingUser.ModifiedOn = DateTime.Now;
                _context.Users.Update(existingUser);
                _context.SaveChanges();
                return existingUser;
            }
        }

    }
}
