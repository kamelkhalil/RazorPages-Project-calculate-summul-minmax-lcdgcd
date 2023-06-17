using Assignment.Models;
using Assignment.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment.Pages
{
    public class MinMaxModel : PageModel
    {
        private readonly ArithmeticAndMath _arithmeticAndMath;

        public MinMaxModel(ArithmeticAndMath arithmeticAndMath)
        {
            _arithmeticAndMath = arithmeticAndMath;
        }

        public void OnGet()
        {
            ViewData["Message"] = "Welcome to MinMax Page";
        }

        public IActionResult OnPost(MathOperationModel model)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            int min = _arithmeticAndMath.Min(model.Param1, model.Param2, model.Param3);
            int max = _arithmeticAndMath.Max(model.Param1, model.Param2, model.Param3);

            ViewData["Message"] = $"The min is: {min}, The max is: {max}";

            return Page();
        }
    }
}
