using System.ComponentModel.DataAnnotations;

namespace ALSN_Db.Models
{
    public class Translator
    {
        [Key]
        public long TranslatorID { get; set; }
        public long UserID { get; set; }
        public int SourceLanguageID { get; set; }
        public int TargetLanguageID { get; set; }

        public User User { get; set; }
        public Language SourceLanguage { get; set; }
        public Language TargetLanguage { get; set; }
    }
}
