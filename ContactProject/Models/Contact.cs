using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContactProject.Models
{
    public class Contact
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        [Key]
        public Int32 Id { get; set; }

        /// <summary>
        /// First Name
        /// </summary>
        [Required]
        [MaxLength(100)]
        public String FirstName { get; set; }

        /// <summary>
        /// Last Name
        /// </summary>
        [Required]
        [MaxLength(100)]
        public String LastName { get; set; }

        /// <summary>
        /// Nickname
        /// </summary>
        [MaxLength(20)]
        public String NickName { get; set; }

        /// <summary>
        /// Display name (not mapped into the db)
        /// </summary>
        [NotMapped]
        public String DisplayAs
        {
            get
            {
                return FirstName + ", " + LastName + ", " + NickName;
            }
        }

        /// <summary>
        /// Date Of Birth
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Phone Number (Australia format)
        /// </summary>
        [Required]
        [MaxLength(20)]
        [DataType(DataType.PhoneNumber)]
        public String PhoneNumber { get; set; }
    }
}