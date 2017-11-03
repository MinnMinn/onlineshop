namespace OnlineShop.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tags
    {
        //public Tags()
        //{
        //    Post = new HashSet<Post>();
        //    Product = new HashSet<Product>();
        //}
        [Key]
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Type { get; set; }
        
        public virtual ICollection<PostTag> PostTags { get; set; }
        
        public virtual ICollection<ProductTag> ProductTags { get; set; }
    }
}
