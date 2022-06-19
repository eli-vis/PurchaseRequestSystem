using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PRS_Project.Models
{
    public class RequestLine
    {
        [Key]
        public int Id { get; set; }

        public int RequestId { get; set; }

        public int ProductId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int Quantity{get;set;}

        [JsonIgnore]

        public Product? Product { get; set; }

        [JsonIgnore]

        public Requests? Requests { get; set; }
    }
}
