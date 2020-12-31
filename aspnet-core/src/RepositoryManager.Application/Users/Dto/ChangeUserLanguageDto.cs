using System.ComponentModel.DataAnnotations;

namespace RepositoryManager.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}