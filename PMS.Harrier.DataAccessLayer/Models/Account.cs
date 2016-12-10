using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace PMS.Harrier.DataAccessLayer.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class Account : IdentityUser
    {
        public Account()
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

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<Account> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }
}
