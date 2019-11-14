using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminGirisi.ORM.Entity
{
    public class Musteriler:BaseEntitiy
    {
       
        [Required]
        public string Adı { get; set; }
        [Required]
        public string Soyadı { get; set; }
        [Required]
        public string TC { get; set; }
        [Required]
        public string EhliyetNo { get; set; }
        [Required]
        public string Telefon { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Adres { get; set; }
        [Required]
        public string Sifre { get; set; }

        public bool? IsAdmin { get; set; }


        //mapping
        List<Arabalar> Cars { get; set; }
    }
}
