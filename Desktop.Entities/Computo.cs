using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Entities
{
    public class Computo
    {
        [Key]
        public int ComputoId { get; set; }

        [MaxLength(80)]
        [Required]
        public string Nombre { get; set; }

        [MaxLength(80)]
        [Required]
        public string Edificio { get; set; }

        [MaxLength(80)]
        [Required]
        public string NumeroComputo { get; set; }

        [Required]

        public int Desktop { get; set; }
        public virtual Desktopp Desktops { get; set; }

    }
}
