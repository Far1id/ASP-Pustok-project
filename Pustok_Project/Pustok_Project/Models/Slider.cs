using System.ComponentModel.DataAnnotations;

namespace Pustok_Project.Models
{
    public class Slider
    {
        public int id { get; set; }
        [Required]
        [StringLength(maximumLength: 35)]
        public string Title1 { get; set; }
        [StringLength(maximumLength: 35)]
        public string Title2 { get; set; }
        [StringLength(maximumLength: 250)]
        public string Text { get; set; }
        [StringLength(maximumLength: 35)]
        public string BtnText { get; set; }
        [StringLength(maximumLength: 250)]
        public string BtnUrl { get; set; }
        [StringLength(maximumLength: 100)]
        public string Image { get; set; }


    }
}
