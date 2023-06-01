using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmailCodeCheckIn.Models.Entity
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
        public List<FileURL> DeploymentDocument { get; set; }
        public string UnitTest { get; set; }
        public string FilesAdded { get; set; }
        public string FilesModified { get; set; }
        public string FilesDeleted { get; set; }
        public string GitBranch { get; set; }
        public string PullRequest { get; set; }
        public string CodeReviewedBy { get; set; }
        public string TargetVersion { get; set; }
        public List<FileURL> SpecificaitionDoc { get; set; }
        public List<FileURL>TechnicalDoc { get; set; }
        public List<FileURL> Scenarios { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }=DateTime.Now;
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
