using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZevaPortal.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public float Weight { get; set; }
        public int FormId { get; set; }
        [ForeignKey("FormId")]
        public virtual Form Form { get; set; }
    }
}
