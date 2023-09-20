using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Programare_medic.Models
{
    public class Spital
    {
        public int ID { get; set; }

        [Display(Name = "Denumire spital")]
        [StringLength(30, MinimumLength = 3)]
        public string DenumireSpital { get; set; }
        public ICollection<Serviciu>? Servicii { get; set; } //navigation property

        public String Imagine { get; set; }

    }
}
