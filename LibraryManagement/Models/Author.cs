using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Tên tác giả")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Giới thiệu về tác giả")]
        public string Description { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}