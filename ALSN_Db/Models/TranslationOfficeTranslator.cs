using System.ComponentModel.DataAnnotations;

namespace ALSN_Db.Models
{
    public class TranslationOfficeTranslator
    {
        [Key]
        public long TranslationOfficeTranslatorID { get; set; }
        public long TranslatorID { get; set; }
        public long TranslationOfficeID { get; set; }

        public User Translator { get; set; }
        public User TranslationOffice { get; set; }
    }
}
