using System;
using System.Collections.Generic;
using System.Text;

namespace PMM.DTO.Movies
{
    public class MovieDto
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string FileLocation { get; set; }
        public IEnumerable<StaffDto> Staffs { get; set; }
    }
}
