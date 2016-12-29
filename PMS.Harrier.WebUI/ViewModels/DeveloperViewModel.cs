using System.ComponentModel.DataAnnotations;

namespace PMS.Harrier.WebUI.ViewModels
{
    public class DeveloperViewModel
    {
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
        [Display(Name = "Adres email")]
        public string Email { get; set; }
    }
}