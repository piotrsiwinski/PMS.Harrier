using System;
using System.Collections.Generic;

namespace PMS.Harrier.DataAccessLayer.Models
{
    public class UserAccount
    {
        public UserAccount()
        {
            this.Project = new HashSet<Project>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsEnabled { get; set; }
        public DateTime? RegisterDate { get; set; }
        public string EmailHash { get; set; }
        public string AccountToken { get; set; }
        public virtual Developer Developer { get; set; }
        public virtual AccountAddress AccountAdress { get; set; }
        public virtual ICollection<Project> Project { get; set; }
    }
}