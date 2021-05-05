using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cet322hw01.Models
{
    public class Student
    {
        public int Id { get; set; }
        [DisplayName("İsmi")]
        [Required]
        public string Name { get; set; }
        [DisplayName("Soyismi")]
        [Required]
        public string Surname { get; set; }
        [DisplayName("Bölümü")]
        public string? Departmant { get; set; } 
        [DisplayName("Doğum Tarihi")]
        [Required]
       
        public DateTime BirthDate { get; set; }
        [DisplayName("Boyu")]
        public decimal? Height { get; set; } 
        [DisplayName("Kilosu")]
        public decimal? Weight { get; set; } 
        
        public DateTime CreationDate { get; set; }
       
        public DateTime LastUpdateDate { get; set; }
        public int Age;
        
       


    }
}
