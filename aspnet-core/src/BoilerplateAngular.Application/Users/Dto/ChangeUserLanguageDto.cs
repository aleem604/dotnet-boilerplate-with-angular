using System.ComponentModel.DataAnnotations;

namespace BoilerplateAngular.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}