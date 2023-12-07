using System.ComponentModel.DataAnnotations;

namespace ALSN_Db.Models
{
    public class Language
    {
        [Key]
        public int LanguageID { get; set; }
        public string LanguageTitle { get; set; }
    }
}
