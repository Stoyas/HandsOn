using PMM.DTO.Enums;

namespace PMM.DTO.Movies
{
    public class StaffDto
    {
        public int StaffId { get; set; }
        public StaffType StaffType { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public ContactInfoDto PrimaryContactInfo { get; set; }
    }
}
