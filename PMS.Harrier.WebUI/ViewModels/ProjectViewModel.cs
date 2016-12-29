using System;
using System.ComponentModel.DataAnnotations;

namespace PMS.Harrier.WebUI.ViewModels
{
    public class ProjectViewModel
    {
        public int ProjectId { get; set; }
        [Display(Name = "Nazwa projektu")]
        public string ProjectName { get; set; }
        [Display(Name = "Data rozpoczęcia")]
        public DateTime? StartDate { get; set; }
        [Display(Name = "Opis")]
        public string Description { get; set; }
    }
}