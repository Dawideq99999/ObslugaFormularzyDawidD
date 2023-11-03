using System.ComponentModel.DataAnnotations;

namespace ObsługaFormularzyDawidD.Models
{

    public class Data
    {
        [Required(ErrorMessage = "Please fill your name")]
        [MinLength(2, ErrorMessage = "Name must be longer than 2 letters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please fill your surname")]
        [MinLength(2)]
        public string Surname { get; set; }


        [Required(ErrorMessage = "Please fill your e-mail address")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}", ErrorMessage = "Please add a valid email address!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please set your password, it needs to be 8-20 digits/letters long")]
        [MinLength(8), MaxLength(20)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password")]
        [Compare("Password", ErrorMessage = "Confirm password doesn't match the password, type again")]
        public string PasswordConfirmation { get; set; }

        [Required(ErrorMessage = "Please add your phone")]
        [RegularExpression(@"^(\d{9})$", ErrorMessage = "Phone number is not correct. Please add correct phone")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please add your age")]
        [Range(10, 80, ErrorMessage = "Age must be between 10 and 80 years")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please choose your city")]
        public string City { get; set; }

        public enum Cities { Cracow = 1, Warsaw = 2, Lublin = 3, Kielce = 4, Gdansk = 5 }

    }
}

