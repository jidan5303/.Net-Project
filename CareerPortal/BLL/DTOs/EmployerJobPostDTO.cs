using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class EmployerJobPostDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string RequiredSkills { get; set; }
        [Required]
        public string EducationLevel { get; set; }
        [Required]
        public string Experience { get; set; }
        [Required]
        public string ApplicationDeadline { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string CompanyMail { get; set; }

        public int Employer_Id { get; set; }

        public int Category_Id { get; set; }
    }
}
