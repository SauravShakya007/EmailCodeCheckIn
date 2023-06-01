using Microsoft.EntityFrameworkCore;

namespace EmailCodeCheckIn.Models
{
    public class CodeCheckInContext:DbContext
    {
        public CodeCheckInContext(DbContextOptions<CodeCheckInContext>options): base(options)
        {
            
        }
        public DbSet<CodeCheckIn> CodeCheckIns { get; set; }
        public object CodeCheckIn { get; internal set; }
    }
}
