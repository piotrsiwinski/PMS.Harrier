using System;
using System.Collections.Generic;

namespace PMS.Harrier.DataAccessLayer.Models
{
    public class Stage
    {
        public Stage()
        {
            this.StageTeam = new HashSet<StageTeam>();
        }

        public int StageId { get; set; }
        public int ProjectId { get; set; }
        public int? StageNumber { get; set; }
        public DateTime? StageStartDate { get; set; }
        public DateTime? StageEndDate { get; set; }
        public short? StageAccepted { get; set; }
        public int? StageLeaderDeveloperId { get; set; }
        public string StageDescription { get; set; }
        public int? StageStatus { get; set; }

        public virtual Project Project { get; set; }
        public virtual ICollection<StageTeam> StageTeam { get; set; }
    }
}