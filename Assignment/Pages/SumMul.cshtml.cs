using Assignment.Models;
using Assignment.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Assignment.Pages
{
    public class SumMulModel : PageModel
    {
        private readonly ArithmeticAndMath _arithmeticAndMath;

        public SumMulModel(ArithmeticAndMath arithmeticAndMath)
        {
            _arithmeticAndMath = arithmeticAndMath;
        }

        public void OnGet()
        {
            ViewData["Message"] = "Welcome to SumMul Page";
        }

        public IActionResult OnPost(MathOperationModel model)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            int result = _arithmeticAndMath.Sum(model.Param1, model.Param2, model.Param3);
            int multiplication = _arithmeticAndMath.Multiply(model.Param1, model.Param2, model.Param3);

            ViewData["Message"] = $"The sum is: {result}, The multiplication is: {multiplication}";

            return Page();
        }
    }
}
