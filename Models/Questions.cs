using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreWebApi.Models
{
    public class Questions
    {
        public int QusetionId { get; set; }
        public int CreatedBy { get; set; }
        public int Title { get; set; }
        public int ControlName { get; set; }
        public int ControlType { get; set; }
        public int ToolTip { get; set; }
        public int isActive { get; set; }

    }
}
