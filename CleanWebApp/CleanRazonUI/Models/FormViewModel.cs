using System;
using System.ComponentModel.DataAnnotations;

namespace CleanRazonUI.Models
{
    public class FormViewModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Address { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Phone")]
        [UIHint("Password")] //подсказка
        public string Phone { get; set; }
        public bool TermsAccepted { get; set; }
    }
}
