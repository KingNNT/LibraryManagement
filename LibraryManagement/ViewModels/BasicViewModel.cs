using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.ViewModels
{
    public class BasicViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}