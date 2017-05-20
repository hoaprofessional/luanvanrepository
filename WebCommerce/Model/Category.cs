using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("CATEGORY")]
    public class Category
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public String CategoryName { get; set; }
        public String Image { get; set; }
        public int NoOfTopics { get; set; }
        public int NoOfLikes { get; set; }
        public int NoOfView { get; set; }
        public string ColorTitleHex { get; set; }
    }
}
