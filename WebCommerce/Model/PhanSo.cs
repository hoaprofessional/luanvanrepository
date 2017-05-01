using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("PHANSO")]
    public class PhanSo
    {
        public int Id { get; set; }
        public int TuSo { get; set; }
        public int MauSo { get; set; }
    }
}
