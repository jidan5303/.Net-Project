using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ManageJobPost
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("employerJobPost")]
        public int JobId { get; set; }
        public bool IsApproved { get; set; }

        public virtual EmployerJobPost employerJobPost { get; set; }
    }
}
