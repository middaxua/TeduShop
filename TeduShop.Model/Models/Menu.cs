using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string URL { get; set; }
        public int? DisplayOrder { get; set; }
        [Required]
        [ForeignKey("GroupID")]
        public int GroupID { get; set; }
        public virtual MenuGroup MenuGroup { get; set; }
        public string Target { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}