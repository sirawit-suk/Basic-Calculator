using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BasicCalculator.Models;
using System.Text;

namespace BasicCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static CalculatorModel calculator;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            calculator = new CalculatorModel();
            return View(calculator);
        }

        public IActionResult Operation(string newValue, string operand)
        {
            if (operand == "add")
            {
                calculator.Value = Convert.ToDouble(newValue);
                calculator.Operand = "add";
            }
            else if (operand == "sub")
            {
                calculator.Value = Convert.ToDouble(newValue);
                calculator.Operand = "sub";
            }
            else if (operand == "mul")
            {
                calculator.Value = Convert.ToDouble(newValue);
                calculator.Operand = "mul";
            }
            else if (operand == "div")
            {
                calculator.Value = Convert.ToDouble(newValue);
                calculator.Operand = "div";
            }
            else if (operand == "equ")
            {
                if (calculator.Operand == "add")
                {
                    calculator.Value += Convert.ToDouble(newValue);
                }
                else if (calculator.Operand == "sub")
                {
                    calculator.Value -= Convert.ToDouble(newValue);
                }
                else if (calculator.Operand == "mul")
                {
                    calculator.Value *= Convert.ToDouble(newValue);
                }
                else if (calculator.Operand == "div")
                {
                    calculator.Value /= Convert.ToDouble(newValue);
                }
                else if (calculator.Operand == "")
                {
                    calculator.Value = Convert.ToDouble(newValue);
                }
            }

            calculator.Value = Math.Round(calculator.Value, 14);
            return Content(Convert.ToString(calculator.Value), "text/plain", Encoding.UTF8);
        }

        public IActionResult AllClear()
        {
            calculator.Value = 0;
            calculator.Operand = "";
            return Content(Convert.ToString(calculator.Value), "text/plain", Encoding.UTF8);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
