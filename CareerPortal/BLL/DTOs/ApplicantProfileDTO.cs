using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ApplicantProfileDTO
    {
        public int Id { get; set; }
        public int UId { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
    }
}
