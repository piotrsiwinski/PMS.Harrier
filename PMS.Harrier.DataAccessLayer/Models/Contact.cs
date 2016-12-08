namespace PMS.Harrier.DataAccessLayer.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Message { get; set; }
        public string Topic { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}