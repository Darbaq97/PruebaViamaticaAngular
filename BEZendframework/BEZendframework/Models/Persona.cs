using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BEZendframework.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName ="varchar(100)")]
        public string nom { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string fecha { get; set; }

        [Required]
        [Column(TypeName = "varchar(16)")]
        public string sueldo { get; set; }

        [Required]
        [Column(TypeName = "varchar(16)")]
        public string idsector { get; set; }

        [Required]
        [Column(TypeName = "varchar(16)")]
        public string idzona { get; set; }


    }
}
