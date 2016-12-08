namespace PMS.Harrier.DataAccessLayer.Models
{
    public class AccountAddress
    {
        public int AccountAdressesId { get; set; }
        public int AccountId { get; set; }
        public string PhoneNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public short IsMainAdress { get; set; }

        public virtual Account Account { get; set; }
    }
}