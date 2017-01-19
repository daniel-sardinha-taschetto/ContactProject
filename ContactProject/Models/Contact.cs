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
        [Key]
        public Int32 Id { get; set; }

        [Required]
        [MaxLength(100)]
        public String FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public String LastName { get; set; }

        [MaxLength(20)]
        public String NickName { get; set; }

        [NotMapped]
        public String DisplayAs
        {
            get
            {
                return FirstName + ", " + LastName + ", " + NickName;
            }
        }
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy")]
        //[DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [MaxLength(20)]
        [DataType(DataType.PhoneNumber)]
        public String PhoneNumber { get; set; }
    }
}