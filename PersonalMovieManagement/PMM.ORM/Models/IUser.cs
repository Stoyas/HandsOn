namespace PMM.ORM.Models
{
    public class User : BaseEntity
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public UserRole UserType { get; set; }
    }

    public enum UserRole
    {
        Admin = 1,
        User = 2
    }
}