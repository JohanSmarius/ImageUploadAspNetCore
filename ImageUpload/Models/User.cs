using System.ComponentModel.DataAnnotations;

namespace ImageUpload.Models;

public class User
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public byte[] Picture { get; set; }

    [Required]
    public string PictureFormat { get; set; }
}
