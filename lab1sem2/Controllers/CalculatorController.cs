using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: отображение формы
        [HttpGet]
        public IActionResult Result()
        {
            var query = Request.Query;
            string expression = query["expression"];

            if (string.IsNullOrEmpty(expression))
                return View();

            int index;
            string resultText = expression;

            index = expression.LastIndexOf("+");
            if (index != -1)
            {
                string before = expression.Substring(0, index);
                string after = expression.Substring(index + 1);
                resultText = before + " плюс " + after;
            }

            index = expression.LastIndexOf("-");
            if (index != -1)
            {
                string before = expression.Substring(0, index);
                string after = expression.Substring(index + 1);
                resultText = before + " минус " + after;
            }

            index = expression.LastIndexOf("*");
            if (index != -1)
            {
                string before = expression.Substring(0, index);
                string after = expression.Substring(index + 1);
                resultText = before + " умножить на " + after;
            }

            index = expression.LastIndexOf("/");
            if (index != -1)
            {
                string before = expression.Substring(0, index);
                string after = expression.Substring(index + 1);
                resultText = before + " разделить на " + after;
            }

            ViewBag.ResultText = resultText;

            return View();
        }

        // POST: обработка формы
        [HttpPost]
        public IActionResult Index(Calculator model, string actionType)
        {
            // если нажата кнопка "Очистить"
            if (actionType == "clear")
            {
                ModelState.Clear();
                return View(new Calculator());
            }
            // проверка валидации
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            decimal operand2Value;

            // преобразуем строку в число
            if (!decimal.TryParse(model.Operand2, out operand2Value))
            {
                ModelState.AddModelError("Operand2", "Введите корректное число");
                return View(model);
            }

            switch (model.Operation)
            {
                case "+":
                    model.Result = model.Operand1 + operand2Value;
                    break;
                case "-":
                    model.Result = model.Operand1 - operand2Value;
                    break;
                case "*":
                    model.Result = model.Operand1 * operand2Value;
                    break;
                case "/":
                    if (operand2Value != 0)
                        model.Result = model.Operand1 / operand2Value;
                    else
                        ModelState.AddModelError("", "Деление на ноль!");
                    break;
            }
            // задаём значение через ViewBag
            ViewBag.ExpectedValue = 10;

            return View(model);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new Calculator());
        }
    }
}
