﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { get; set; }
        [MaxLength(256)]
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [MaxLength(256)]
        public string UpdatedBy { get; set; }
        [MaxLength(256)]
        string MetaKeyword { get; set; }
        [MaxLength(256)]
        string MetaDescription { get; set; }
        public bool Status { get; set; }
        string IAuditable.MetaKeyword { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IAuditable.MetaDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
