using Microsoft.Owin;
using Owin;
using Quiz.EntityModels;

[assembly: OwinStartupAttribute(typeof(QuotesQuiz.Startup))]
namespace QuotesQuiz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
        
    }
}
