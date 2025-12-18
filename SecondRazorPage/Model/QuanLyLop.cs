using System.ComponentModel.DataAnnotations;

namespace SecondRazorPage.Model
{
    public class QuanLyLop
    {
        [Key]
        public int Id { get; set; }

        [Required]

        [Display(Name = "STT")]
        public int? Stt { get; set; }

        [Display(Name = "Mã lớp")]
        public string? MaLop { get; set; }

        [Display(Name = "Tên môn học")]

        public string? TenMonHoc { get; set; }




        [Display(Name = "Phòng")]
        public string? Phong { get; set; }



        [Display(Name = "Mã giảng viên")]
        [Required]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "Mã giảng viên gồm 8 ký tự")]
        public string MSGV { get; set; }

    }
}
