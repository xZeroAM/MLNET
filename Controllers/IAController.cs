using Microsoft.AspNetCore.Mvc;
using MyMLApp;

namespace SentimentalAIWeb.Controllers
{
    public class IAController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AnalizarTexto(string textInput)
        {
            //Load sample data
            var sampleData = new SentimentModel.ModelInput()
            {
                Col0 = textInput,
            };

            //Load model and predict output
            var result = SentimentModel.Predict(sampleData);

            return View("Index", result);
        }

    }
}
