using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndZendFramework.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }

        [Required]
       
        public string nom { get; set; }

        [Required]
        
        public string fecha { get; set; }

        [Required]
        
        public string sueldo { get; set; }

        [Required]
        
        public string Id_sector { get; set; }

        [Required]
        public string Id_zona { get; set; }
    }
}
