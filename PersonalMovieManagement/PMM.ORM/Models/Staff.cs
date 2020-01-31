namespace PMM.ORM.Models
{
    public class Staff : BaseEntity
    {
        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public int PrimaryContactInfoId { get; set; }
        public StaffType StaffType { get; set; }
    }

    public enum Gender
    {
        Male = 1,
        Female = 2
    }

    public enum StaffType
    {
        Producer = 1,
        Director = 2,
        Editor = 3,
        Actor = 4,
        ScreenWriter = 5,
        ProductionDesigner = 6,
        ArtDirector = 7,
        CostumeDesigner = 8,
        Cinematographer = 9,
        MusicSupervisor = 10,
    }
}