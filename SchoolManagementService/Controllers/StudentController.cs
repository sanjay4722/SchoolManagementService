using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementService.Modal;
using SchoolManagementService.SchoolData;

namespace SchoolManagementService.Controllers
{
    //[Route("api/[controller]")]
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ApplicationContext _Context;
        public StudentController(ApplicationContext Context)
        {
            _Context = Context;
        }
        [Route("getAllStudentLeaveDetails")]
        public IActionResult getAllStudentLeaveDetails()
        {
            var data = _Context.TBT_StudentLeaveRequest.ToList();
            if(data.Count > 0 && data !=null) 
            {
                return Ok(data);
            }
            else
            {
                return NotFound();
            }
        }
        [Route("getAllStudentLeaveDetailsByID")]
        public IActionResult getAllStudentLeaveDetailsByID(int AdmissionNo)
        {
            var data = _Context.TBT_StudentLeaveRequest.Where( e => e.AdmissionNo == AdmissionNo ).SingleOrDefault();
            if (data != null)
            {
                return Ok(data);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [Route("AddStudentLeaveDetails")]
        public IActionResult AddStudentLeaveDetails([FromBody] StudentLeaveRequest model)
        {
           if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
           else
            {
                var data = new StudentLeaveRequest
                {

                    AdmissionNo = model.AdmissionNo,
                    LeaveFromDate = model.LeaveFromDate,
                    LeaveToDate = model.LeaveToDate,
                    Remarks = model.Remarks
                };
                _Context.TBT_StudentLeaveRequest.Add(data);
                _Context.SaveChanges();
                return Ok(data);
            }
        }
    }


   
}
