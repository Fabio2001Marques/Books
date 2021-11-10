using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required (ErrorMessage = "Titulo nulo")]
        [StringLength(512)]
        public string Title { get; set; }
        public string Description { get; set; }
       
        [DisplayName("Autor")]
        public int AutorId { get; set; }

        public Autor Autor { get; set; }
    }
}
