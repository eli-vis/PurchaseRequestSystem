using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PRS_Project.Models
{
    public class Requests
    {
        //public static string StatusReview = "Review";
        //public static string StatusApproved = "Approved";
        //public static string StatusRejected = "Rejected";

        [Key]
        public int Id { get; set; }
        [StringLength(140)]
        public string Description { get; set; }
        [StringLength(140)]
        public string Justification { get; set; }
        [StringLength(140)]
        public string? RejectionReason //RejectionReason must be provided when the request is rejected
        {
            get; set;

        }

        [StringLength(20)]
        public string DeliveryMode { get; set; }

        [StringLength(10)]
        public string Status { get; set; } //make this to where the user can't change it.

        [Column(TypeName = "decimal(11,2)")]
        public decimal Total { get; set; } //make this to where the user can't change it.
                                           //auto calculated by adding up all the lines currently on the request

        public int UserId { get; set; }

        [JsonIgnore]
        public User? User { get; set; }
        /* [ForeignKey("RequestLine")*//*]*/
        [JsonIgnore]
        public List<RequestLine>? RequestLines { get; set; }


    }
}
