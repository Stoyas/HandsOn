namespace PMM.ORM.Models
{
    public class Movie: BaseEntity
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string FileLocation { get; set; }
    }
}