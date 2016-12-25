namespace PMS.Harrier.WebUI.ViewModels
{
    public class AddDeveloperViewModel
    {
        public int ProjectId { get; set; }
        public int DeveloperId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ExperienceFromDate { get; set; }
        public string CostPerHour { get; set; }
        public string WeekAvailability { get; set; }
        public bool IsSelected { get; set; }
    }
}