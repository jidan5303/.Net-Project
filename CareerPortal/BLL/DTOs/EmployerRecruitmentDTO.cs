using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class EmployerRecruitmentDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public bool Shortlist { get; set; }
        public int Employer_Id { get; set; }
        public int Applicant_Id { get; set; }
        public int JobPost_Id { get; set; }
    }
}
