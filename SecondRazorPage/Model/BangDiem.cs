using System.ComponentModel.DataAnnotations;

namespace SecondRazorPage.Model
{
    public class BangDiem
    {
        [Key]
        public int Id { get; set; }

        [Required]

      

        [Display(Name = "STT")]
        public int Stt { get; set; }      

        [Display(Name = "Năm học")]
        public int NamHoc { get; set; }

        [Display(Name = "Học kỳ")]
        public int HocKy { get; set; }

        [Display(Name = "Mã môn học")]
        public string MaMonHoc { get; set; }

        [Display(Name = "Tên môn học")]
        
        public string TenMonHoc { get; set; }

        

         

        [Display(Name = "Số TC")]
        public int SoTC { get; set; }       

        [Display(Name = "Lớp")]
        public string Lop { get; set; }          

        [Display(Name = "Loại điểm")]
        public string LoaiDiem { get; set; }    

        [Display(Name = "Điểm (hệ 10)")]
        public float Diem { get; set; }

        [Display(Name = "Ghi chú")]
        public string GhiChu { get; set; }

        [Display(Name = "Chương trình")]
        public string ChuongTrinh{ get; set; }

        [Display(Name = "Hệ")]
        public string He { get; set; }

        [Display(Name = "Mã số sinh viên/học viên")]
        public string StudentCode { get; set; }
    }
}
