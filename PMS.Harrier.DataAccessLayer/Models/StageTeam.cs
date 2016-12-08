using System;

namespace PMS.Harrier.DataAccessLayer.Models
{
    public class StageTeam
    {
        public int StageTeamId { get; set; }
        public int StageId { get; set; }
        public short? IsStageLeader { get; set; }
        public int DeveloperId { get; set; }

        public virtual Developer Developer { get; set; }
        public virtual Stage Stages { get; set; }
    }
}