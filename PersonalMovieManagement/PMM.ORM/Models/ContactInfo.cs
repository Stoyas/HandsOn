namespace PMM.ORM.Models
{
    public class ContactInfo: BaseEntity
    {
        /// <summary>
        /// Identity of contact information
        /// </summary>
        public int ContactInfoId { get; set; }
        /// <summary>
        /// City name
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// State/Province
        /// </summary>
        public string StateProvince { get; set; }
        /// <summary>
        /// Zip code
        /// </summary>
        public string ZipCode { get; set; }
        /// <summary>
        /// County name
        /// </summary>
        public string County { get; set; }
        /// <summary>
        /// Phone number
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Fax number
        /// </summary>
        public string Fax { get; set; }
        /// <summary>
        /// Email address
        /// </summary>
        public string Email { get; set; }
    }
}