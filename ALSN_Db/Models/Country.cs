using System.ComponentModel.DataAnnotations;

namespace ALSN_Db.Models
{
    public class Country
    {
        [Key]
        public long CountryID { get; set; }
        public string CountryName { get; set; }
    }
}
