using System.ComponentModel.DataAnnotations;

namespace SecondRazorPage.Model
{
    public class HocBong
    {
        [Key]
        public int Id { get; set; }
        [Required]
       
        [Display(Name = "Năm học")]
        public string NamHoc { get; set; }

       
        [Display(Name = "Học kỳ")]
        public int HocKy { get; set; }

        [Display(Name = "Loại")]
        public string Loai { get; set; }

        [Display(Name = "Số tiền")]
        public string SoTien { get; set; }



        [Display(Name = "Thời gian")]
        [DataType(DataType.Date)]
        public DateTime ThoiGian { get; set; }

        [Display(Name = "Mã số sinh viên/học viên")]
        public string StudentCode { get; set; }
    }
}

