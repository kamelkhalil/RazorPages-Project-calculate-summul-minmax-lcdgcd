using Assignment.Models;
using Assignment.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment.Pages
{
    [BindProperties]
    public class LcdGcdModel : PageModel
    {
        private readonly ArithmeticAndMath _arithmeticAndMath;

        public LcdGcdModel(ArithmeticAndMath arithmeticAndMath)
        {
            _arithmeticAndMath = arithmeticAndMath;
        }

        public void OnGet()
        {
            ViewData["Message"] = "Welcome to LcdGcd Page";
        }

        public IActionResult OnPost(MathOperationModel model)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            int lcm = _arithmeticAndMath.Lcm(model.Param1, model.Param2, model.Param3);
            int gcd = _arithmeticAndMath.Gcd(model.Param1, model.Param2);

            ViewData["Message"] = $"The lcm is: {lcm}, The gcd is: {gcd}";

            return Page();
        }
    }
}
