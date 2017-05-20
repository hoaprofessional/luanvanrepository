using System;
using Model;
using Repository;

namespace ViewModel.Home
{
    public class LastestTopicViewModel : BaseViewModel<Model.Topic>
    {
        public String Avatar { get; set; }
        public String TopicName { get; set; }

        public override void OnConvert(Model.Topic source, params object[] values)
        {
            base.OnConvert(source, values);
            IUserRepository userRepository = (IUserRepository)values[0];
            ApplicationUser user = userRepository.GetSingleByCondition(x => x.Id == source.AuthorId);
            if (user != null)
            {
                Avatar = user.Avatar;
            }
        }
    }
}
