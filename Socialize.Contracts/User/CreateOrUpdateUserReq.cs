using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socialize.Contracts.User
{
    public class CreateOrUpdateUserReq
    {
        public string? GoogleId { get; set; }
        public string FullName { get; set; }
        public string? Email { get; set; }
        public string PhotoURL { get; set; }
        public string Bio { get; set; }
        public string Address { get; set; }
        public string School { get; set; }
    }
}
