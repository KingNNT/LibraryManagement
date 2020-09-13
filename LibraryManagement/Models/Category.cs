using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Tên thể loại")]
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}