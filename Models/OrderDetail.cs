﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCamping.Models
{
    [Table("OrderDetails")]
    public class OrderDetail : BaseModel
    {
        [Key]
        public int ORDD_ID { get; set; }
        public required int PRO_ID { get; set; }
        public required int ORD_ID { get; set; }
        public required int Quantity { get; set; }
        public required decimal Price { get; set; }
        public decimal DiscountPrice { get; set; }

        [ForeignKey("ORD_ID")]
        public virtual Order? Order { get; set; }

        [ForeignKey("PRO_ID")]
        public virtual Product? Product { get; set; }
    }
}
