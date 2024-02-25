﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FebSec10Prj.Models
{
    [Table("Student")]
    public class Student
    {
          
        [Key]
        public int Id {  get; set; }
        public string? Name { get; set; }
        public string? Class {  get; set; }
        public string? SchoolName {  get; set; }
    }
}
