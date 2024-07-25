using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MyPortfolio.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [DisplayName("프로젝트명")]
        public string ProjectName { get; set; }

        [Required]
        [MaxLength(400)]
        [DisplayName("프로젝트 내용")]
        public string Description { get; set; }

        // 300*500 or 600 이미지 
        [Required]
        public string FilePath { get; set; }
    }
}
