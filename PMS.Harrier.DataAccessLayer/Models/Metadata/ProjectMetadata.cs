using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace PMS.Harrier.DataAccessLayer.Models.Metadata
{
    public class ProjectMetadata
    {
        public int Id { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 3)]
        [Display(Name = "Nazwa projektu")]
        [Remote("ValidateProjectName", "Project")]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreationDateTime { get; set; }
    }
}