using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ApplicantProfile
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UId { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Mail { get; set; }
        [Required]
        [StringLength(11, MinimumLength = 11)]
        public string Phone { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [StringLength(20)]
        public string Gender { get; set; }
        [Required]
        public string DOB { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<ApplicantEducationalQualification> Qualifications { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public ApplicantProfile()
        {
            Qualifications=new List<ApplicantEducationalQualification>();
            Notifications=new List<Notification>();
        }
    }
}
