using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreWebApi.Models
{
    public class Answers
    {
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public int Title { get; set; }
        
        public int ToolTip { get; set; }
        public int SortId { get; set; }
        public int isActive { get; set; }

    }
}
