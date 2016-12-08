namespace PMS.Harrier.DataAccessLayer.Models
{
    public class ProjectData
    {
        public int ProjectDataId { get; set; }
        public int ProjectId { get; set; }
        public string ProjectDataDirectory { get; set; }
        public virtual Project Project { get; set; }
    }
}