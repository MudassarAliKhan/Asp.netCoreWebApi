using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreWebApi.Models
{
    public class Flows
    {
        [Key]
        public int FlowId { get; set; }
        [Required]
        public String CreatedBy { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String JiraCustomTemplateProjectKey { get; set; }
        public Boolean isActive { get; set; }

    }
}
