using System;

namespace PMM.ORM.Models
{
    public class BaseEntity
    {
        /// <summary>
        /// Created by user
        /// </summary>
        public User CreatedBy { get; set; }

        /// <summary>
        /// Created date time
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Updated by user
        /// </summary>
        public User UpdatedBy { get; set; }

        /// <summary>
        /// Updated date
        /// </summary>
        public DateTime UpdatedDate { get; set; }
    }
}