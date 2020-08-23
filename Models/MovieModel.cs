using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IndexedDBApp.Models
{
    public class MovieModel
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Title { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
