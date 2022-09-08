using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
    public class Product : BaseEntity
    {
        [StringLength(75)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(100)]
        public string slug { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

 
    }
}
