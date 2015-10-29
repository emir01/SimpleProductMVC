using System.ComponentModel.DataAnnotations;

namespace PA.DataModel.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
