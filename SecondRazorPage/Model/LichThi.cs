using System.ComponentModel.DataAnnotations;

namespace SecondRazorPage.Model
{
    public class LichThi
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "STT")]
        public int? Stt { get; set; }

        [Display(Name = "Năm học")]
        public string? NamHoc { get; set; }

        [Display(Name = "Học kỳ")]

        public int? HocKy { get; set; }

        [Display(Name = "Ngày thi")]
        [DataType(DataType.Date)]
        public DateTime? NgayThi { get; set; }


        [Display(Name = "Giờ thi")]
        public string? GioThi { get; set; }

        [Display(Name = "Môn thi")]
        public string? MonThi { get; set; }

        [Display(Name = "Phòng thi")]

        public string? PhongThi { get; set; }

        [Display(Name = "Cơ sở thi")]
        public string? CoSoThi { get; set; }
    }
}
