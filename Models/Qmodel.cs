using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examlast.Models
{
    public class Qmodel
    {
        public int Id { get; set; }
        public string QuestionTitle { get; set; }
        public string QFull { get; set; }
        public string QA { get; set; }
        public string QB { get; set; }

        public string QC { get; set; }

        public string QD { get; set; }

        public string QCorrect { get; set; }
    }
}
