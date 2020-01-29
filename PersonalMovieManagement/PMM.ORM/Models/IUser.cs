namespace PMM.ORM.Models
{
    public interface IUser
    {
    }

    public enum UserRole
    {
        Admin = 1,
        User = 2
    }

    public class User : IUser
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public UserRole UserType { get; set; }
    }
}