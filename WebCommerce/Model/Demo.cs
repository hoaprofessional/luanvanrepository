using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    // 1_ThemBang: st1. Thêm 1 lớp tương tự như thế này khai báo những trường tương ứng là column
    /// <summary>
    /// Tạo 1 bảng DEMO
    /// </summary>
    [Table("DEMO")]
    public class Demo : Auditable
    {
        /// <summary>
        /// 2_CSCot: st1. Thêm, xóa, chỉnh sửa 1 trường trong lớp cần chỉnh sửa tương ứng
        /// </summary>
        /// 
        public int Id { get; set; }
        public string Name { get; set;} 
        public string Decription { get; set; }
    }
}
