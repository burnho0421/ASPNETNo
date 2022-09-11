using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspnetNo.Models
{
    public class Note
    {

        [Key]
        public int NoteNo { get; set; } // 게시물 번호

        [Required]
        public string NoteTitle { get; set; } //게시물 제목

        [Required]
        public string NoteContents { get; set; } // 게시물 내용

        [Required]
        public int UserNo { get; set; } //게시물 작성자

        [ForeignKey("UserNo")] // 외래키 설정
        public virtual User User { get; set; }

    }
}
