namespace onlinediary.core.Models.Db
{
    public partial class Contact
    {
        public long Id { get; set; }
        public long DiaryId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

        public virtual Diary Diary { get; set; }
    }
}
