using System.ComponentModel.DataAnnotations;

namespace kingdom.Models
{
    public class Knight
    {
       public int Id { get; set; }
       public string Name { get; set; }
       [Required]
       public int CastleId { get; set; }
       public string Mission { get; set; } 
    }
}