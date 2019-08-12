﻿using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstract
{
    public class Auditable : IAuditable
    {
        public DateTime? CreatedDate { get; set; }
        [MaxLength(255)]
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [MaxLength(255)]
        public string UpdatedBy { get; set; }
        [MaxLength(255)]
        public string MetaKeyWord { get; set; }
        [MaxLength(255)]
        public string MetaDescription { get; set; }
        public bool Status { get; set; }
    }
}