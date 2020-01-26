using System.ComponentModel.DataAnnotations;

namespace maarif.myproject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}