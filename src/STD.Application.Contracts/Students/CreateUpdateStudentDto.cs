using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace STD.Students
{
    public class CreateUpdateStudentDto
    {

        [Required]
        [StringLength(128)]
        public string Name { get; set; }


        [Required]
        [StringLength(128)]
        public string Email { get; set; }


        [Required]
        [StringLength(128)]
        public string RollNo { get; set; }


        [Required]
        [StringLength(128)]
        public string City { get; set; }


        [Required]
        [StringLength(128)]
        public string Branch { get; set; }





    }
}
