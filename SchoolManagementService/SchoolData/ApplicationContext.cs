using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SchoolManagementService.Modal;

namespace SchoolManagementService.SchoolData
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            
       }

        public DbSet<StudentLeaveRequest> TBT_StudentLeaveRequest { get; set; }
    }
}
