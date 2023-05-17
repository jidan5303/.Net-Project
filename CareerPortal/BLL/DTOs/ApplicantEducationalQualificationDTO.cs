using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ApplicantEducationalQualificationDTO
    {
        
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public string LevelofEducation { get; set; }
        public string InstituteName { get; set; }
        public int YearofPassing { get; set; }
        public string Degree { get; set; }
    }
}
