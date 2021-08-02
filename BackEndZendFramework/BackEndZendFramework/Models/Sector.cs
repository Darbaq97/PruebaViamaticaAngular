using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndZendFramework.Models
{
    public class Sector
    {
        [Key]
        public int Id_sector { get; set; }

        [Required]
       
        public string descripcion { get; set; }

        
    }
}
