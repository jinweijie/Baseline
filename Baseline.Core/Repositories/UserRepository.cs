using Baseline.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseline.Core.Repositories
{
    public class UserRepository
    {
        public static List<User> GetAllUsers()
        {
            using (var ctx = EFContext.Get())
            {
                return ctx.Users.Include("Roles").Include("Addresses").ToList();
            }
        }
    }
}
