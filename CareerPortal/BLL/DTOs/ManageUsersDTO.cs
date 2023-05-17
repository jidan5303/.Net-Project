using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ManageUsersDTO
    {
        public int Id { get; set; }

        public int ApplicantID { get; set; }

        public int EmployerID { get; set; }
    }
}
