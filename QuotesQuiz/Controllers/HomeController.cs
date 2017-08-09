using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiz.Data;
using Quiz.EntityModels;

namespace QuotesQuiz.Controllers
{
    public class HomeController : Controller
    {
        private QuizContext context;

        public HomeController()
        {
            this.context = new QuizContext();
        }

        public ActionResult Quiz()
        {

            IEnumerable<Quote> quotes = this.context.Quotes;

            return View(quotes);
        }


        public ActionResult Settings()
        {

            return View();
        }

        public ActionResult MultipleChoice()
        {
            IEnumerable<Quote> quotes = this.context.Quotes;

            return View(quotes);
           
        }


    }
}