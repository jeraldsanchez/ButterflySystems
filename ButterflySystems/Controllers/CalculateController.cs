using ButterflySystems.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace ButterflySystems.Controllers
{
    public class CalculateController : Controller
    {
        private readonly ICalculateService _calculateService;
        private readonly ILogger<CalculateController> _logger;

        public CalculateController(ICalculateService calculateService, ILogger<CalculateController> logger)
        {
            _calculateService = calculateService;
            _logger = logger;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string firstNumber, string secondNumber, string operation)
        {
            try
            {
                var answer = 0.0m;
                if (firstNumber == null || secondNumber == null)
                {
                    ViewBag.Result = "Both numbers are required!";
                    return View();
                }

                switch (operation)
                {
                    case "+":
                        answer = _calculateService.CalculateAdd(Convert.ToDecimal(firstNumber), Convert.ToDecimal(secondNumber));
                        break;
                    case "-":
                        answer = _calculateService.CalculateSubtract(Convert.ToDecimal(firstNumber), Convert.ToDecimal(secondNumber));
                        break;
                    case "*":
                        answer = _calculateService.CalculateMultiply(Convert.ToDecimal(firstNumber), Convert.ToDecimal(secondNumber));
                        break;
                    case "/":
                        answer = _calculateService.CalculateDivide(Convert.ToDecimal(firstNumber), Convert.ToDecimal(secondNumber));
                        break;
                }

                ViewBag.Result = answer;
            }
            catch (ArithmeticException ex)
            {
                _logger.LogError("Error ArithmeticException while calculating with the error: {error}", ex);
                ViewBag.Result = "Err: Make sure that you are inputting numbers only!";
            }
            catch (Exception ex)
            {
                _logger.LogError("Error while calculating with the error: {error}", ex);
                ViewBag.Result = "Err: Please try again later";
            }
         
            return View();
        }
    }
}
