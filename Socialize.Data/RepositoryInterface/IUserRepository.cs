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
    }
}
