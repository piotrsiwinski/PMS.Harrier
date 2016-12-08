using System;

namespace PMS.Harrier.DataAccessLayer.Models
{
    public class TechnologyDeveloper
    {
        public int TechnologyDeveloperId { get; set; }
        public int TechnologyId { get; set; }
        public int DeveloperId { get; set; }
        public DateTime? ExperienceFrom { get; set; }
        public int? SkillLevel { get; set; }
        public virtual Developer Developer { get; set; }
        public virtual Technology Technologies { get; set; }

    }
}