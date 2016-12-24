using System;

namespace PMS.Harrier.WebUI.ViewModels
{
    public class ProjectViewModel
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public DateTime? StartDate { get; set; }
        public string Description { get; set; }
    }
}