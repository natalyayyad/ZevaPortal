using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZevaPortal.Models
{
    public class Assessment
    {
        public int AssessmentId { get; set; }
        public DateTime Date { get; set; }
        public int FormId { get; set; }
        [ForeignKey("FormId")]
        public virtual Form Form { get; set; }
        public Guid Id { get; set; }
    }
}
