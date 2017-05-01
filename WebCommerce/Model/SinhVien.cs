using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("SINHVIEN")]
    public class SinhVien : Auditable
    {
        /// <summary>
        /// 2_CSCot: st1. Thêm, xóa, chỉnh sửa 1 trường trong lớp cần chỉnh sửa tương ứng
        /// </summary>
        /// 
        public int Id { get; set; }
        public string MSSV { get; set; }
        public string HoTen { get; set; }
    }
}
