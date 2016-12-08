namespace PMS.Harrier.DataAccessLayer.Models
{
    public class ProjectTechnology
    {
        public int ProjectTechnologyId { get; set; }
        public int TechnologyId { get; set; }
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public virtual Technology Technologies { get; set; }
    }
}