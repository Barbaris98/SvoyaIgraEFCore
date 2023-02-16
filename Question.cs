using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvoyaIgraEFCore
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; } = null!;
        public string Answer { get; set; } = null!;
        public int QuestionPoint { get; set; }
        public string Category { get; set; } = null!;

    }
}
