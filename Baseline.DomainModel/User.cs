using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseline.DomainModel
{
    public class User
    {
        private ICollection<Address> addresses;
        private ICollection<Role> roles;

        public User()
        {
            this.addresses = new List<Address>();
            this.roles = new List<Role>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Address> Addresses
        {
            get
            {
                return this.addresses;
            }
            set
            {
                this.addresses = value;
            }
        }

        public virtual ICollection<Role> Roles
        {
            get
            {
                return this.roles;
            }
            set
            {
                this.roles = value;
            }
        }
    }
}
