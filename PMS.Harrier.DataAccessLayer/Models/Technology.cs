using System.Collections.Generic;

namespace PMS.Harrier.DataAccessLayer.Models
{
    public class Technology
    {
        public Technology()
        {
            this.ProjectTechnologies = new HashSet<ProjectTechnology>();
            this.TechnologiesDeveloper = new HashSet<TechnologyDeveloper.TechnologiesDeveloper>();
        }

        public int TechnologyId { get; set; }
        public string TechnologyName { get; set; }
        public short IsActive { get; set; }
        public virtual ICollection<ProjectTechnology> ProjectTechnologies { get; set; }
        public virtual ICollection<TechnologyDeveloper.TechnologiesDeveloper> TechnologiesDeveloper { get; set; }
    }
}