using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
  
    public class MathOperationModel
    {
        [Required]
        public int Param1 { get; set; }

        [Required]
        public int Param2 { get; set; }

        [Required]
        public int Param3 { get; set; }
    }
}
