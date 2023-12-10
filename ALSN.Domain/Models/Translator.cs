using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALSN.Domain.Models
{
    public class Translator
    {
        [Key]
        public int TranslatorId { get; set; }
        public int UserId { get; set; }
        public int SourceLanguageId { get; set; }
    //    public int TargetLanguageId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
        [ForeignKey("SourceLanguageId")]
        public Language SourceLanguage { get; set; }
       // [ForeignKey("TargetLanguageId")]
      //  public Language TargetLanguage { get; set; }
    }
}
