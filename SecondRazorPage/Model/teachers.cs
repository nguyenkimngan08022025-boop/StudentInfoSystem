using System.ComponentModel.DataAnnotations;

namespace SecondRazorPage.Model
{
    public class Teacher
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Họ và tên")]
        [Required]
        [StringLength(100)]
        public string name { get; set; }
        [Display(Name = "Giới tính")]
        [Required]
        [StringLength(5)]
        public string sex { get; set; }
        [Display(Name = "Ngày sinh")]
        [Required]
        [StringLength(20)]
        public string born { get; set; }
        [Display(Name = "Mật khẩu")]
        [Required]
        [StringLength(20)]
        [DataType(DataType.Password)]
        public string? pass { get; set; }

        [Display(Name = "Mã giảng viên")]
        [Required]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "Mã giảng viên gồm 8 ký tự")]
        public string MSGV { get; set; }

        [Display(Name = "Chuyên ngành")]
        [Required]
        public string monday { get; set; }

        [Display(Name = "Email")]
        [EmailAddress]
        public string? email { get; set; }
        [Display(Name = "Tỉnh/Thành phố")]
        [EmailAddress]
        public string? noio { get; set; }
        [Display(Name = "Quốc gia")]
        [EmailAddress]
        public string? qgia { get; set; }

        [Display(Name = "Số điện thoại")]
        [StringLength(10)]
        [RegularExpression(@"^0\d{9}$")]
        public string? telnum { get; set; }
    }
}