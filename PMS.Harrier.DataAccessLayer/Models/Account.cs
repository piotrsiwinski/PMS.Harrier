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
            this.AccountAdresses = new HashSet<AccountAddress>();
            this.Developer = new HashSet<Developer>();
            this.Project = new HashSet<Project>();
        }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<Account> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public int AccountId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsEnabled { get; set; }
        public string Country { get; set; }
        public DateTime? RegisterDate { get; set; }
        public string EmailHash { get; set; }
        public string AccountToken { get; set; }

        public virtual ICollection<AccountAddress> AccountAdresses { get; set; }
        public virtual ICollection<Developer> Developer { get; set; }
        public virtual ICollection<Project> Project { get; set; }
    }
}
