using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MriduBooks.Models
{
    public class Book
    {
        internal int id;

        [Key]
        public int Id { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Author { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string Review { get; set; }

        public int ISBN { get; set; }
    }
}
