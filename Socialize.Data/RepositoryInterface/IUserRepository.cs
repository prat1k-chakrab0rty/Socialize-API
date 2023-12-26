using Socialize.Contracts.User;
using Socialize.Domain.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socialize.Data.RepositoryInterface
{
    public interface IUserRepository
    {
        Task<List<User>> GetAll();
        Task<User> CreateOrUpdate(CreateOrUpdateUserReq req);
    }
}
