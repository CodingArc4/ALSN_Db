using System.ComponentModel.DataAnnotations;

namespace ALSN.Domain.Models
{
    public class Language
    {
        [Key]
        public int LanguageId { get; set; }
        public string LanguageTitle { get; set; }
    }
}
