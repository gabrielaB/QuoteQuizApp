using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.EntityModels
{
    public class Answer
    {
        public int Id { get; set; }
        public string AnswerContent { get; set; }
        public virtual int QuoteId { get; set; }
    }
}
