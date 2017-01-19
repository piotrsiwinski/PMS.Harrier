namespace PMS.Harrier.DataAccessLayer.Models
{
    public class Issue
    {
        public int IssueId { get; set; }
        public int ProjectId { get; set; }
        public int ReporterDeveloperId { get; set; }
        public int? DeveloperId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double LoggedHours { get; set; }
        public string SolutionDescription { get; set; }

        public Project Project { get; set; }
        public Developer Developer { get; set; }
    }
}