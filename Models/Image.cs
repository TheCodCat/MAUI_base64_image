using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Image
    {
        [Key] public int Id { get; set; }
        public string Base64 { get; set; } = string.Empty;
    }
}
