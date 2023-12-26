using System.ComponentModel.DataAnnotations;

namespace Socialize.Common
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
