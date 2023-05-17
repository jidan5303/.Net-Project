using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ManageEmployerJobPostDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int Salary { get; set; }
        public string Location { get; set; }
        public string RequiredSkills { get; set; }
        public string EducationLevel { get; set; }
        public string Experience { get; set; }
        public string ApplicationDeadline { get; set; }
        public string CompanyName { get; set; }
        public string CompanyMail { get; set; }
        public int Employer_Id { get; set; }
        public int Category_Id { get; set; }
    }
}
