using System.ComponentModel.DataAnnotations;

namespace Lap1.Models
{
    public class Student
    {
        public int Id { get; set; }//Mã sinh viên
        [StringLength(100, MinimumLength = 4, ErrorMessage ="Bạn cần nhập tối thiểu 4 kí tự")]
        [Required(ErrorMessage = "Tên bắt buộc phải được nhập!")]
        public string? Name { get; set; } //Họ tên
        [Required(ErrorMessage = "Email bắt buộc phải được nhập!")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[gmail]+\.[com]{2,4}", ErrorMessage ="Email cần phải có đuôi @gmai.com")]
        public string? Email { get; set; } //Email
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Bạn cần nhập có chữ hoa, chữ thường, kí tự đặc biệt và tối thiểu 8 kí tự")]
        [Required(ErrorMessage = "Password bắt buộc phải được nhập!")]
        public string? Password { get; set; }//Mật khẩu
        [Required]
        public Branch? Branch { get; set; }//Ngành học
        [Required(ErrorMessage = "Giới tính bắt buộc phải chọn!")]
        public Gender? Gender { get; set; }//Giới tính
        public bool IsRegular { get; set; }//Hệ: true-chính qui, false-phi cq
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Địa chỉ bắt buộc phải được nhập!")]
        public string? Address { get; set; }//Địa chỉ
        [Range(typeof(DateTime), "1/1/1963", "12/31/2005", ErrorMessage ="Năm sinh phải từ 1963 đến 2005")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Ngày sinh bắt buộc phải được nhập!")]
        public DateTime? DateOfBorth { get; set; }//Ngày sinh
        [Range(typeof(float), "0", "10", ErrorMessage ="Điểm cần nằm trong khoảng từ 0 đến 10")]
        [Required(ErrorMessage ="Bạn phải nhập điểm")]
        public float? Diem { get; set; }

    }
}
