using System.ComponentModel.DataAnnotations;

namespace WebApplicationTest.Models
{
    public class Conversion
    {
        public int? ConversionId { get; set; }
        public string? InitialMetric { get; set; }

        [Display(Name = "Initial Value :")]
        [Required(ErrorMessage = "Champs requis !")]
        public float? InitialValue { get; set; }

        [Required(ErrorMessage = "Champs requis !")]
        public string? FinalMetric { get; set; }

        public float? FinalValue { get; set; }
    }
}
