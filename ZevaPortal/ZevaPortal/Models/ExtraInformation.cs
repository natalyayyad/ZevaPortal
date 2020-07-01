using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZevaPortal.Models
{
    public class ExtraInformation
    {
        public int ExtraInformationId { get; set; }
        public string Title { get; set; }
        public int FormId { get; set; }
        [ForeignKey("FormId")]
        public virtual Form Form { get; set; }

    }
}
