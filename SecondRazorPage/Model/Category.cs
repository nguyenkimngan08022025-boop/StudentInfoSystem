using System.ComponentModel.DataAnnotations;

namespace SecondRazorPage.Model
{
    public class Category   // = Bảng Thông tin chung
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Họ và tên")]
        public string Name { get; set; }       // Họ tên

        [Display(Name = "Mã số sinh viên/học viên")]
        public string StudentCode { get; set; }    // 24120999

        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Giới tính")]
        public string Gender { get; set; }

        [Display(Name = "Nơi sinh")]
        public string PlaceOfBirth { get; set; }   // Tỉnh Quảng Nam

        [Display(Name = "Khóa tuyển")]
        public int? IntakeYear { get; set; }       // 2025

        [Display(Name = "Ngành / Nhóm ngành")]
        public string Major { get; set; }          // Chuỗi dài trong hình

        [Display(Name = "Bậc đào tạo")]
        public string DegreeLevel { get; set; }    // Cử nhân

        [Display(Name = "Loại hình đào tạo")]
        public string TrainingType { get; set; }   // Chính quy

        [Display(Name = "Chuyên ngành")]
        public string Specialization { get; set; }


        

    }
}
