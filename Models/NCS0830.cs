using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenCaoSang830.Models
{
    [Table("NCS0830s")]
    public class NCS0830
    {
        [Key, Column(TypeName = "varchar"), StringLength(20)]
        public string NCSId { get; set; }
        [StringLength(50), Required, Display(Name = "Tên")]
        public string NCSName { get; set; }
        [Required, Display(Name = "Giới tính")]
        public Boolean NCSGender { get; set; }
    }
}