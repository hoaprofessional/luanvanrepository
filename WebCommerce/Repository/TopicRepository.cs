using Model;
using Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ITopicRepository : IRepository<Topic>
    {
        IEnumerable<Topic> GetTopicsByCatId(int catId);
    }

    public class TopicRepository : BaseRepository<Topic>, ITopicRepository
    {
        public TopicRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }

        public IEnumerable<Topic> GetTopicsByCatId(int catId)
        {
            return GetMulti(x => x.CatParentId == catId);
        }
    }
}
