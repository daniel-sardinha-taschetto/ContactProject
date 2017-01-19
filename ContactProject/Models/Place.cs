using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactProject.Models
{
    public class Place
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        [Key]
        public Int32 Id { get; set; }

        /// <summary>
        /// Place Name
        /// </summary>
        [Required]
        [MaxLength(100)]
        public String Name { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        [Required]
        [MaxLength(200)]
        public String Address { get; set; }
    }
}