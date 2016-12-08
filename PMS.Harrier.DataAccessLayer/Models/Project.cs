using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PMS.Harrier.DataAccessLayer.Models.Metadata;

namespace PMS.Harrier.DataAccessLayer.Models
{
    
    public class Project
    {
        public Project()
        {
            this.ProjectData = new HashSet<ProjectData>();
            this.ProjectDeveloper = new HashSet<ProjectDeveloper>();
            this.ProjectStage = new HashSet<ProjectStage>();
            this.ProjectTechnology = new HashSet<ProjectTechnology>();
            this.Stage = new HashSet<Stage>();
        }

        public int ProjectId { get; set; }
        //public int AccountId { get; set; }
        public string ProjectName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DeathLine { get; set; }
        public DateTime? EndDate { get; set; }
        public int? EstimatedHours { get; set; }
        public int? LoggedHours { get; set; }
        public string Description { get; set; }
        public int? StartedByAccount { get; set; }
        public int ProjectStatus { get; set; }
        public int ProjectLeaderId { get; set; }

        //public virtual Account Account { get; set; }
        public virtual ICollection<ProjectData> ProjectData { get; set; }
        public virtual ICollection<ProjectDeveloper> ProjectDeveloper { get; set; }
        public virtual ICollection<ProjectStage> ProjectStage { get; set; }
        public virtual ICollection<ProjectTechnology> ProjectTechnology { get; set; }
        public virtual ICollection<Stage> Stage { get; set; }

    }
}