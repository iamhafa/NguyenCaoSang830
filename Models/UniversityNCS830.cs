using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenCaoSang830.Models
{
    public class UniversityNCS830
    {
        [Key, Column(TypeName = "varchar"), StringLength(20), Display(Name = "ID Đại học")]
        public string UniversityId { get; set; }
        [StringLength(50), Display(Name = "Tên Đại học")]
        public string UniversityName { get; set; }
    }
}