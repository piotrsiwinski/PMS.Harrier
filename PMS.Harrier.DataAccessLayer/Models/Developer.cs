using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Owin.Security;

namespace PMS.Harrier.DataAccessLayer.Models
{
    public class Developer
    {
        public Developer()
        {
            this.ProjectDeveloper = new HashSet<ProjectDeveloper>();
            this.StageTeam = new HashSet<StageTeam>();
            this.TechnologiesDeveloper = new HashSet<TechnologyDeveloper>();
        }
        public int DeveloperId { get; set; }
        public string AccountId { get; set; }
        public string ExperienceFromDate { get; set; }
        public string CostPerHour { get; set; }
        public string WeekAvailability { get; set; }
        public virtual Account Account { get; set; }
        public virtual ICollection<ProjectDeveloper> ProjectDeveloper { get; set; }
        public virtual ICollection<StageTeam> StageTeam { get; set; }
        public virtual ICollection<TechnologyDeveloper> TechnologiesDeveloper { get; set; }
    }
}