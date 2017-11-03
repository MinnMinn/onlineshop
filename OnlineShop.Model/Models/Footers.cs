namespace OnlineShop.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Footers
    {
        [Key]
        [StringLength(50)]
        public string ID { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
