using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.Topic
{
    public class TopicListViewModel : BaseViewModel<Model.Topic>
    {
        public int Id { get; set; }
        public string TopicName { get; set; }
        public int NoOfViews { get; set; }
        public int NoOfLikes { get; set; }
        public int NoOfReplies { get; set; }
        public string LastPost { get; set; }
        public DateTime LastPostTime { get; set; }
        public string Image { get; set; }
        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public string LastComment { get; set; }
    }
}
