using System.ComponentModel.DataAnnotations;
namespace SecondRazorPage.Model
{
    public class DiemRenLuyen
    {
        [Key]
        public int Id { get; set; }

        [Required]
       
        [Display(Name = "Năm học")]
        public string NamHoc { get; set; }       
        [Display(Name = "Học kỳ")]
        public int HocKy { get; set; }

        [Display(Name = "Điểm")]
        public int Diem { get; set; }

        [Display(Name = "Xếp loại")]
        public string XepLoai { get; set; }

        

        [Display(Name = "Thời điểm")]
        [DataType(DataType.Date)]
        public DateTime ThoiDiem{ get; set; }

        [Display(Name = "Mã số sinh viên/học viên")]
        public string StudentCode { get; set; }


    }
}
