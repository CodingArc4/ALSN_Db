using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALSN.Domain.Models
{
    public class TranslationOfficeTranslator
    {
        [Key]
        public int TranslationOfficeTranslatorId { get; set; }
        public int TranslatorId { get; set; }
        public int TranslationOfficeId { get; set; }

        [ForeignKey("TranslatorId")]
        public Translator Translator { get; set; }
        
        [ForeignKey("TranslationOfficeId")]
        public UserBank TranslationOffice { get; set; }
    }
}
