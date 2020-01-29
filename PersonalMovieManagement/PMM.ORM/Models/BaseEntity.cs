using System;

namespace PMM.ORM.Models
{
    public class BaseEntity
    {
        public User CreatedBy{ get; set; }
        public DateTime CreatedDate { get; set; }
        public User UpdatedBy{ get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}