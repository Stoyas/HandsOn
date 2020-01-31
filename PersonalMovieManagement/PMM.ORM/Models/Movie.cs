namespace PMM.ORM.Models
{
    public class Movie: BaseEntity
    {
        /// <summary>
        /// Identity of a movie
        /// </summary>
        public int MovieId { get; set; }
        /// <summary>
        /// Name of the movie
        /// </summary>
        public string MovieName { get; set; }
        /// <summary>
        /// File location of the movie, could be a url or a file direction
        /// </summary>
        public string FileLocation { get; set; }
    }
}