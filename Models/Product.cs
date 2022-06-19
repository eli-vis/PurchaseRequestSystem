﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PRS_Project.Models
{
    [Index(nameof(PartNbr), IsUnique = true)]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [StringLength(30)]
        public string PartNbr { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        [Column(TypeName = "decimal(11,2)")]
        public decimal Price { get; set; }
        [StringLength(30)]
        public string Unit { get; set; }
        [StringLength(255)]
        public string? PhotoPath { get; set; }

        [JsonIgnore]

        public Vendors? Vendor { get; set; }

        //[ForeignKey("RequestLine")]
        [JsonIgnore]

        public List<RequestLine>? RequestLines { get; set; }
    }
}
