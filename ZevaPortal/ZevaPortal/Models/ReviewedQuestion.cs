using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZevaPortal.Models
{
    public class ReviewedQuestion
    {
        public int ReviewedQuestionId { get; set; }
        public int ReviewedCategoryId { get; set; }
        [ForeignKey("ReviewedCategoryId")]
        public virtual ReviewedCategory ReviewedCategory { get; set; }
        public int Rate { get; set; }
    }
}
