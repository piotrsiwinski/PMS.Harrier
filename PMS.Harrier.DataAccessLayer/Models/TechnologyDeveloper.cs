using System;

namespace PMS.Harrier.DataAccessLayer.Models
{
    public class TechnologyDeveloper
    {
        public partial class TechnologiesDeveloper
        {
            public int TechnologiesDeveloperId { get; set; }
            public int TechnologiesId { get; set; }
            public int DeveloperId { get; set; }
            public Nullable<System.DateTime> experience_from { get; set; }
            public Nullable<int> skill_level { get; set; }
            public Nullable<short> is_tech_promotor { get; set; }
            public Nullable<short> technology_promotor_approved { get; set; }

            public virtual Developer Developer { get; set; }
            public virtual Technology Technologies { get; set; }
        }
    }
}