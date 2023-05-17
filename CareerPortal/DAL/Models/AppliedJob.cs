using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class AppliedJob
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("ApplicantProfile")]
        public int ApplicantId { get; set; }
        [ForeignKey("EmployerJobPosts")]
        public int JobId { get; set; }

        public virtual ApplicantProfile ApplicantProfile { get; set; }
        public virtual EmployerJobPost EmployerJobPosts { get; set; }
    }
}
