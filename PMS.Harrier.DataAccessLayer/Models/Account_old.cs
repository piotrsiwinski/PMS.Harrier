using System;
using System.Collections.Generic;

namespace PMS.Harrier.DataAccessLayer.Models
{
    public class AccountOld
    {
        public AccountOld()
        {
            this.AccountAdresses = new HashSet<AccountAddress>();
            this.Developer = new HashSet<Developer>();
            this.Project = new HashSet<Project>();
        }

        public int AccountId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public short? IsActive { get; set; }
        public short? IsEnabled { get; set; }
        public string Country { get; set; }
        public string RegisterDate { get; set; }
        public string EmailHash { get; set; }
        public string AccountToken { get; set; }

        public virtual ICollection<AccountAddress> AccountAdresses { get; set; }
        public virtual ICollection<Developer> Developer { get; set; }
        public virtual ICollection<Project> Project { get; set; }
    }
}