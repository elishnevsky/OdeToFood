using System.ComponentModel.DataAnnotations;

namespace OdeToFood.ViewModels
{
    public class RegisterViewModel
    {
        [Required, MaxLength(256), Display(Name = "Username")]
        public string UserName { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password), Compare(nameof(Password)), Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
