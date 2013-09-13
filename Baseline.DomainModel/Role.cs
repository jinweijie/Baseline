using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseline.DomainModel
{
    public class Role
    {
        private ICollection<User> users;

        public Role()
        {
            this.users = new List<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<User> Users
        {
            get
            {
                return this.users;
            }
            set
            {
                this.users = value;
            }
        }
    }
}
