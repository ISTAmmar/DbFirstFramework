using System.ComponentModel.DataAnnotations;

namespace Sigma.Models
{
    public class AspNetRole
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}