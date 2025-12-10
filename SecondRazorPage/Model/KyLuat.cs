using System.ComponentModel.DataAnnotations;

namespace SecondRazorPage.Model
{
    public class KyLuat
    {
        [Key]
        public int Id { get; set; }
        [Required]
        
        [Display(Name = "Hình thức")]
        public string? HinhThuc { get; set; }

        [Display(Name = "Thời gian")]
        [DataType(DataType.Date)]
        public DateTime? ThoiGian { get; set; }

        [Display(Name = "Ghi chú")]
        public string? GhiChu { get; set; }

        [Display(Name = "Mã số sinh viên/học viên")]
        public string StudentCode { get; set; }

    }
}
