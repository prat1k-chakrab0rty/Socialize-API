using Microsoft.EntityFrameworkCore;
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
    }
}
