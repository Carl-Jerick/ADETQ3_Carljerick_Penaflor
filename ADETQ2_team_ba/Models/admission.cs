using System.ComponentModel.DataAnnotations;

namespace Enrollment.Models
{
    public class admission
    {
        [Required(ErrorMessage = "Student Name:")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Student Number:")]
        public string No { get; set; }
        [Required(ErrorMessage = "Age:")]
        public string Age { get; set; }
        [Required(ErrorMessage = "Address")]
        public string address { get; set; }
    }
}
