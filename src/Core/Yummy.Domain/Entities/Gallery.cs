using System.ComponentModel.DataAnnotations;

namespace Yummy.Domain.Entities
{
    public class Gallery
    {
        [Key]
        public int ImageID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ImageURL { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }
}