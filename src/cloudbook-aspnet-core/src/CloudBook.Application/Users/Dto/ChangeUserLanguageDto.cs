using System.ComponentModel.DataAnnotations;

namespace CloudBook.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}