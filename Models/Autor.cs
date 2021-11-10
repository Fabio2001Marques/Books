using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Models
{
    public class Autor
    {
        public int AutorId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
