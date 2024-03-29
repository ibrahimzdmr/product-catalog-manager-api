﻿using System.ComponentModel.DataAnnotations;

namespace ProductCatalogManagerAPI.Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Key]
        public string Code { get; set; }
        public string Name { get; set; }
        public string? Picture { get; set; }
        public decimal Price { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
