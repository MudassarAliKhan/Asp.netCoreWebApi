using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreWebApi.Models
{
    public class FlowQuestions
    {
        public int FlowQuestionId { get; set; }
        public int CreatedBy { get; set; }
        public int FlowId { get; set; }
        public int QusetionId { get; set; }
        public int SortId { get; set; }
        public int isActive { get; set; }
    }
}
