using System.ComponentModel.DataAnnotations;

namespace SecondRazorPage.Model
{
    public class ThoiKhoaBieu
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

        [Display(Name = "Mã môn học")]
        public string MaMonHoc { get; set; }


        [Display(Name = "Tên môn học")]
        public string TenMonHoc { get; set; }

        [Display(Name = "Tín chỉ")]
        public int TinChi { get; set; }

        [Display(Name = "Thời gian")]

        public string Thoigian { get; set; }

        [Display(Name = "Phòng học")]
        public string PhongHoc { get; set; }

        [Display(Name = "Mã số sinh viên/học viên")]
        public string StudentCode { get; set; }



    }
}
