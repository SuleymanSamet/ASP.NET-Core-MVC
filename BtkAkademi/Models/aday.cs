using System.ComponentModel.DataAnnotations;

namespace BtkAkademi.Models
{
    public class aday
    {
        [Required(ErrorMessage ="Email alanı zorunludur")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage ="İsim alanı zorunludur")]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage ="Soyisim alanı zorunludur")]
        public string LastName { get; set; } = string.Empty;
        
        public int? Age { get; set; }
        
        public string SelectedCourse { get; set; } = string.Empty;
        public DateTime ApplyAt { get; set; }

        public aday()
        {
            ApplyAt = DateTime.Now;
        }
    }
    
}