using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZevaPortal.Models
{
    public class Guideline
    {
        public int GuidelineId { get; set; }
        public int ScaleFrom { get; set; }
        public int ScaleTo { get; set; }
        public string Description { get; set; }
        public int FormId { get; set; }
        [ForeignKey("FormId")]
        public virtual Form Form { get; set; }

    }
}
