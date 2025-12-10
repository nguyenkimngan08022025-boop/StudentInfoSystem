using System.ComponentModel.DataAnnotations;

namespace SecondRazorPage.Model
{
    public class HocPhi
    {

        [Key]
        public int Id { get; set; }
        [Required]
        
        [Display(Name = "STT")]
        public int Stt { get; set; }

        [Display(Name = "Năm học")]
        public string NamHoc { get; set; }

        [Display(Name = "Học kỳ")]
        public int HocKy { get; set; }      

        [Display(Name = "Khoản thu")]
        public string KhoanThu { get; set; }         

        [Display(Name = "Phải thu")]
        public decimal PhaiThu { get; set; }    

        [Display(Name = "Đã thu")]
        public decimal DaThu { get; set; }
        [Display(Name = "Còn lại")]
        public decimal ConLai => PhaiThu - DaThu;

        [Display(Name = "Mã số sinh viên/học viên")]
        public string StudentCode { get; set; }


    }
}
