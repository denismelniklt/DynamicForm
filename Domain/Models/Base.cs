using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Domain.Models
{
    public class Base
    {
        [Key]
        public int Id { get; set; }
    }
}
