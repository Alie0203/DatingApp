using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username {get;set;}

        [Required]
        [StringLength(12 , MinimumLength=6,  ErrorMessage = "Your password has to be a minimum of 8 or a maximum of 12 characters")]
         public string Password {get;set;}

         //[Required] invalidates null entry 
         //[EmailAddress] is used to check email entry
         //Validations checks can be made using DataAnnotations
          
      
    }
}