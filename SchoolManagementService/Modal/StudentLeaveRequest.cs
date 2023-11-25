using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagementService.Modal
{
    public class StudentLeaveRequest
    {
        [Key]
        public int LeaveID { get; set; }
        public int AdmissionNo { get; set; }
        public DateTime LeaveFromDate { get; set; }
        public DateTime LeaveToDate { get; set; }
        public string Remarks { get; set; }
         
        
    }
}
