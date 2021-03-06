﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZevaPortal.Models
{
    public class ReviewedCategory
    {
        public int ReviewedCategoryId { get; set; }
        public string Comment { get; set; }
        public float Average { get; set; }
        public int AssessmentId { get; set; }
        [ForeignKey("AssessmentId")]
        public virtual Assessment Assessment { get; set; }

    }
}
