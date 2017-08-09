using Quiz.EntityModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quiz.EntityModels
{
    public class Quote
    {
        public Quote()
        {
            this.PossibleAnswers = new HashSet<Answer>();

        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string QuoteContent { get; set; }

        public string SuggestedAnswer { get; set; }


        [Required]
        public string CorrectAnswer { get; set; }

    
        public virtual ICollection<Answer> PossibleAnswers { get; set; }

        
    }
}

