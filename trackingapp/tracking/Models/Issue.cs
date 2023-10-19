using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;

namespace tracking.Models
{
    public class Issue
    {
     
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;
        [Required]
        [StringLength(300)]
        public string Description { get; set; } = string.Empty;
        public Priority Priority { get; set; }
        public IssueType IssueType { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Completed { get; set; }


    }

    public enum IssueType { 
        Feature, Bug, Documenation 
    }

    public enum Priority
    {
        Low, Medium, High
    }


}
