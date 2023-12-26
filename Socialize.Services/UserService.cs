using Socialize.Contracts.User;
using Socialize.Data.RepositoryInterface;
using Socialize.Domain.EntityModel;
using Socialize.Services.BusinessInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socialize.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository  _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<User>> GetAll()
        {
            var result = await _userRepository.GetAll();
            return result;
        }
        public async Task<User> CreateOrUpdate(CreateOrUpdateUserReq req)
        {
            var result = await _userRepository.CreateOrUpdate(req);
            return result;
        }
    }
}
