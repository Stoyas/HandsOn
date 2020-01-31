using System;

namespace PMM.ORM.Models
{
    public class BaseEntity
    {
        /// <summary>
        /// Id of created user
        /// </summary>
        public int CreatedBy { get; set; }

        /// <summary>
        /// Created date time
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Id of updated user
        /// </summary>
        public int UpdatedBy { get; set; }

        /// <summary>
        /// Updated date
        /// </summary>
        public DateTime UpdatedDate { get; set; }
    }
}