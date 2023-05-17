using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ApplicantJobApplyDTO
    {
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public string PositionName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string ExpectedSalary { get; set; }  
        public string StartTime { get; set; }
        public int JobId { get; set; }
    }
}
