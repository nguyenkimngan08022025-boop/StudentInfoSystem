using System.ComponentModel.DataAnnotations;

namespace SecondRazorPage.Model
{
    public class LichDay
    {

        [Key]
        public int Id { get; set; }

        [Required]

        [Display(Name = "Thứ")]
        public string? Thu{ get; set; }

        [Display(Name = "Ngày")]
        public string? Ngay{ get; set; }

        [Display(Name = "Ca học")]

        public string? CaHoc { get; set; }

       


        [Display(Name = "Môn học")]
        public string? MonHoc { get; set; }

        [Display(Name = "Lớp")]
        public string? Lop { get; set; }


        [Display(Name = "Phòng")]
        public string? Phong { get; set; }


        [Display(Name = "Trạng thái")]
        public string? TrangThai { get; set; }


        [Display(Name = "Mã giảng viên")]
        [Required]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "Mã giảng viên gồm 8 ký tự")]
        public string MSGV { get; set; }

    }
}
