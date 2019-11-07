using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPortal.Logic
{
   public  class TopicManager
    {
        NewsPortalDB _db;
       public TopicManager(NewsPortalDB db)
        {
            _db = db;
        }

        public List<Topic>GetAll()
        {
            return _db.Topics.ToList();
        }

        public Topic Get(int id)
        {
            var topic = _db.Topics.FirstOrDefault(u => u.Id == id);
            return topic;
        }
    }
    
}
