﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Purchase
    {
        [Column("PurchaseId")]
        public string Id { get; set; }

        public string TourName { get; set; }

        public string UserName { get; set; }
    }
}
