namespace PMS.Harrier.DataAccessLayer.Models
{
    public class AccountAddress
    {
        public int AccountAddressId { get; set; }
        public string PhoneNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public bool? IsMainAdress { get; set; }
        public string Country { get; set; }
        public virtual Account Account { get; set; }
    }
}