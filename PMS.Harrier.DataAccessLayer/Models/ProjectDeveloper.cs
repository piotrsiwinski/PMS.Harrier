﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Harrier.DataAccessLayer.Models
{
    public class ProjectDeveloper
    {
        [Key, ForeignKey("Developer"), Column(Order = 0)]
        public int DeveloperId { get; set; }
        [Key, ForeignKey("Project"), Column(Order = 1)]
        public int ProjectId { get; set; }
        public virtual Developer Developer { get; set; }
        public virtual Project Project { get; set; }
    }
}