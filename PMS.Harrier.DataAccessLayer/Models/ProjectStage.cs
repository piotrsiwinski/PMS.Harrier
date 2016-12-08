namespace PMS.Harrier.DataAccessLayer.Models
{
    public class ProjectStage
    {
        public int ProjectStageId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string DeathLine { get; set; }
        public string StageNumber { get; set; }
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}