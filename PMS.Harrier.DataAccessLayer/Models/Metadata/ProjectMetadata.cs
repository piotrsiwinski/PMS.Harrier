using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace PMS.Harrier.DataAccessLayer.Models.Metadata
{
    public class ProjectMetadata
    {
        [Required]
        [StringLength(25, MinimumLength = 3)]
        [Display(Name = "Nazwa projektu")]
        [Remote("ValidateProjectName", "Project")]
        public string ProjectName { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Opis")]
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
    }
}