using System.ComponentModel.DataAnnotations;

namespace PMS.Harrier.WebUI.ViewModels
{
    public class AddDeveloperViewModel
    {
        public int ProjectId { get; set; }
        public int DeveloperId { get; set; }
        [Display(Name = "Imię")]
        public string FirstName { get; set; }
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }
        [Display(Name = "Doświadczenie od")]
        public string ExperienceFromDate { get; set; }
        [Display(Name = "Stawka godzinowa")]
        public string CostPerHour { get; set; }
        [Display(Name = "Dostępność tygodniowa")]
        public string WeekAvailability { get; set; }
        public bool IsSelected { get; set; }
    }
}