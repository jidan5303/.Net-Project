using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ManageCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public virtual ICollection<EmployerJobPost> empJobPosts { get; set; }
        public ManageCategory()
        {
            empJobPosts= new List<EmployerJobPost>();
        }
    }
}
