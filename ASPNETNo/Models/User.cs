using System.ComponentModel.DataAnnotations;

namespace AspnetNo.Models
{
    public class User
    {

        [Key] //PK 설정
        public int UserNo { get; set; } // 사용자 번호

        [Required] // Not Null 설정
        public string  UserName { get; set; } // 사용자 이름

        [Required]
        public string UserId { get; set; } // 사용자 ID

        [Required]
        public  string UserPassword { get; set; } // 사용자 PW
    }
}
