using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmailCodeCheckIn.Models
{
    public class CodeCheckIn
    {
        [Key]
       
        public int CodeId { get; set; }
        public string From { get; set; }
        public List<SendTo> SendTo { get; set; }
        public string Synopsis { get; set; }
        public string Description { get; set; }
        public string ImpactAnalysis { get; set; }
        public string DeploymentDocument { get; set; }
        public string UnitTest { get; set; }
        public List<FileURL> FileURL {get; set;}
    }
    public class FileURL
    {
        [Key]
        public int Id { get; set; }
        public string URL { get; set; }

        [ForeignKey("CodeCheckIn")]
        public int CodeCheckInId { get; set; }
        public CodeCheckIn CodeCheckIn { get; set; }
    }
    public class SendTo
    {
        [Key]
        public int Id { get; set; }
        public string To { get; set; }

        [ForeignKey("CodeCheckIn")]
        public int CodeCheckInId { get; set; }
        public CodeCheckIn CodeCheckIn { get; set; }
    }
}
