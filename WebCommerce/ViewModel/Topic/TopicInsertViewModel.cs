using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.Topic
{
    public class TopicInsertViewModel
    {
        public String TopicName { get; set; }
        public string Content { get; set; }
        public int CatParentId { get; set; }
    }
}
