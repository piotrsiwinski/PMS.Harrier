namespace PMS.Harrier.DataAccessLayer.Models
{
    public class ProjectDeveloper
    {
        public int ProjectDeveloperId { get; set; }
        public int DeveloperId { get; set; }
        public int ProjectId { get; set; }
        public virtual Developer Developer { get; set; }
        public virtual Project Project { get; set; }
    }
}