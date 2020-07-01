using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZevaPortal.Models
{
    public class FilledExtraInformation
    {

        public int FilledExtraInformationId { get; set; }
        public string Description { get; set; }
        public int AssessmentId { get; set; }
        [ForeignKey("AssessmentId")]
        public virtual Assessment Assessment { get; set; }

    }
}
