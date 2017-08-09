namespace Quiz.Data.Migrations
{
    using EntityModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Quiz.Data.QuizContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Quiz.Data.QuizContext context)
        {
            context.Quotes.AddOrUpdate(q => q.CorrectAnswer,
                new Quote
                {
                    QuoteContent = "There is no love without forgiveness, and there is no forgiveness without love.",
                    CorrectAnswer = "Bryant H. McGill",
                    SuggestedAnswer = "Kevin Spacey",
                    PossibleAnswers =
                { new Answer {AnswerContent= "Kevin Spacey" },new Answer {AnswerContent= "Peace Pilgrim" },new Answer {AnswerContent= "Bryant H. McGill"} }

                },
               new Quote
               {
                   QuoteContent = "Pleasure in the job puts perfection in the work",
                   CorrectAnswer = "Aristotle",
                   SuggestedAnswer = "Confucius",
                   PossibleAnswers =
                   { new Answer { AnswerContent="Confucius" },new Answer { AnswerContent="Aristotle"},new Answer {AnswerContent= "Nelson Mandela"} }
               },
                   new Quote
                   {
                       QuoteContent = "If you realized how powerful your thoughts are, you would never think a negative thought.",
                       CorrectAnswer = "Peace Pilgrim",
                       SuggestedAnswer = "Peace Pilgrim",
                       PossibleAnswers =
                       { new Answer {AnswerContent= "Vince Lombardi" } ,new Answer {AnswerContent= "Peace Pilgrim" },new Answer {AnswerContent= "Benjamin Franklin" } }
                   },
            new Quote
            {
                QuoteContent = "Deep into that darkness peering, long I stood there, wondering, fearing, doubting, dreaming dreams no mortal ever dared to dream before",
                CorrectAnswer = "Edgar Allan Poe",
                SuggestedAnswer = "Edgar Allan Poe",
                PossibleAnswers =
                { new Answer {AnswerContent= "Confucius" },new Answer {AnswerContent= "Abraham Lincoln" },new Answer {AnswerContent= "Edgar Allan Poe"} }
            },
                new Quote
                {
                    QuoteContent = "I leave you my portrait so that you will have my presence all the days and nights that I am away from you.",
                    CorrectAnswer = "Frida Kahlo",
                    SuggestedAnswer = "Confucius",
                    PossibleAnswers =
                { new Answer {AnswerContent= "Confucius" },new Answer {AnswerContent= "Abraham Lincoln" },new Answer {AnswerContent= "Frida Kahlo"}

                }
                });
        }
    }
}
