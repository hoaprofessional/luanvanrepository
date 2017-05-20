using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("TOPIC")]
    public class Topic : Auditable
    {
        public int Id { get; set; }
        public string TopicName { get; set; }
        public string Content { get; set; }
        public int NoOfViews { get; set; }
        public int NoOfLikes { get; set; }
        public int NoOfReplies { get; set; }
        public int CatParentId { get; set; }
        public string LastPost { get; set; }
        public DateTime LastPostTime { get; set; }
        public string Image { get; set; }
        public string LastComment { get; set; }
        public string AuthorId { get; set; }
    }
}
