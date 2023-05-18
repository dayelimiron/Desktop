using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Entities
{
    public class Desktopp
    {

        [Key]
        public int DesktopId { get; set; }
        [MaxLength(50)]
        [Required]
        public string Nombre { get; set; }

        [MaxLength(50)]
        [Required]
        public string Marca { get; set; }

        [MaxLength(50)]
        [Required]
        public string Procesador { get; set; }


        [MaxLength(50)]
        [Required]
        public string MemoriaRAM { get; set; }



        public virtual ICollection<Computo> Computos { get; set; }
    }
}
