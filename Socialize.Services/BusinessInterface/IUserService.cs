using Socialize.Domain.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socialize.Services.BusinessInterface
{
    public interface IUserService
    {
        Task<List<User>> GetAll();
    }
}
