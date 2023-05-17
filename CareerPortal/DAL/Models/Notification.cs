using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Message { get; set; }
        [ForeignKey("ApplicantProfile")]
        public int ApplicantId { get; set; }

        public virtual ApplicantProfile ApplicantProfile  { get; set; }
    }
}
