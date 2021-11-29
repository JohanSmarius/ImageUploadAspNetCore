using System.ComponentModel.DataAnnotations;

namespace ImageUpload.Models;

public class UserViewModel
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public IFormFile Picture { get; set; }
}
