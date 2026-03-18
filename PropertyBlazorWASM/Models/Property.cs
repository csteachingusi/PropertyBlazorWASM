using System.ComponentModel.DataAnnotations;

namespace PropertyBlazorWASM.Models
{
    public class Property
    {
        [Key]
        public int PropertyID { get; set; }

        [Required]
        [MaxLength(100)]
        public string PropertyName { get; set; }

        [MaxLength(255)]
        public string Address { get; set; }

        [MaxLength(20)]
        public string UnitNumber { get; set; }

        public decimal MonthlyRent { get; set; }
    }
}
