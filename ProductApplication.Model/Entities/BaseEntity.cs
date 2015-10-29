using System.ComponentModel.DataAnnotations;

namespace PA.Model.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
