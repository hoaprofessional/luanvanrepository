using System;
using Common;
using Model;
using Repository;

namespace ViewModel.Home
{
    public class TopicViewModel : BaseViewModel<Model.Topic>
    {
        public String Avatar { get; set; }
        public String TopicName { get; set; }
        public int NoOfViews { get; set; }
        public int NoOfLikes { get; set; }
        public int NoOfComments { get; set; }
        public String CreateDateStr { get; set; }
        public String CreatedBy { get; set; }
        public override void OnConvert(Model.Topic source, params object[] values)
        {
            if (source.CreatedDate != null) 
                CreateDateStr = DateHelper.DateStr(source.CreatedDate.Value);
            base.OnConvert(source, values);
            IUserRepository userRepository = (IUserRepository)values[0];
            ApplicationUser user = userRepository.GetSingleByCondition(x => x.Id == source.AuthorId);
            if (user != null)
            {
                CreatedBy = user.Name;
                Avatar = user.Avatar;
            }
        }
    }
}
