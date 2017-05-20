using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Ghi chu menu chua parentId = 0 tuc la khong co parent
    /// </summary>
    [Table("WEBMENU")]
    public class Menu
    {
        /// <summary>
        /// 2_CSCot: st1. Thêm, xóa, chỉnh sửa 1 trường trong lớp cần chỉnh sửa tương ứng
        /// </summary>
        /// 
        public int Id { get; set; }
        [MaxLength(50)]
        public string MenuName { get; set; }
        [MaxLength(500)]
        public string MenuUrl { get; set; }
        public int MenuParentId { get; set; }
        public string FaSymbol { get; set; }
    }
}
