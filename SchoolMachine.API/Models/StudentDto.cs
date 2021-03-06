﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolMachine.API.Models
{
    public class StudentDto
    {
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(60, ErrorMessage = "First Name can't be longer than 60 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(60, ErrorMessage = "Last Name can't be longer than 60 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Middle Name is required")]
        [StringLength(60, ErrorMessage = "Middle Name can't be longer than 60 characters")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime BirthDate { get; set; }
    }
}
