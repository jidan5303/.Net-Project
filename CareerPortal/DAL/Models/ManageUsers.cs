using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{

    public class ManageUsers
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("applicantProfile")]
        public int ApplicantID { get; set; }
        [ForeignKey("employerProfiles")]
        public int EmployerID { get; set; }
        public virtual ApplicantProfile applicantProfile { get; set; }
        public virtual EmployerProfile employerProfiles { get; set; }
    }
}
