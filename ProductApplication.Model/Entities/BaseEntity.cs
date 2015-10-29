using System.ComponentModel.DataAnnotations;

namespace PA.Core.DataModel.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
