﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PRS_Project.Models
{
    //[Index(nameof(Id), IsUnique = true)]
    [Index(nameof(Code), IsUnique = true)]
    public class Vendors
    {
   
        
            [Key]
            public int Id { get; set; }
            [StringLength(30)]
            public string Code { get; set; }
            [StringLength(30)]
            public string Name { get; set; }
            [StringLength(30)]
            public string Address { get; set; }
            [StringLength(30)]
            public string City { get; set; }
            [StringLength(2)]
            public string State { get; set; }
            [StringLength(5)]
            public string Zip { get; set; }
            [StringLength(12)]
            public string? Phone { get; set; }
            [StringLength(255)]
            public string? Email { get; set; }


        [JsonIgnore]
        public List<Product>? Products { get; set; }
        
    }
}
