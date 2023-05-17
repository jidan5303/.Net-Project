using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ApplicantEducationalQualification
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("ApplicantProfile")]
        [Required]
        public int ApplicantId { get; set; }
        [Required]
        public string LevelofEducation { get; set; }
        [Required]
        public string InstituteName { get; set; }
        [Required]
        public int YearofPassing { get; set; }
        [Required]
        public string Degree { get; set; }
        public virtual ApplicantProfile ApplicantProfile { get; set; }
    }
}
