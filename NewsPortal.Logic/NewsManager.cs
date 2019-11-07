using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPortal.Logic
{
    public class NewsManager
    {
        NewsPortalDB _db;
        public NewsManager(NewsPortalDB db)
        
        {
            _db = db;
        }

        public List<News>GetByCategory(int categoryId)
        {
            var news = _db.News
                .Where(u => u.CategoryId == categoryId)
                .OrderByDescending(i => i.CreatedOn)
                .Take(10)
                .ToList();
            return news;
        }
        public News Get(int id)
        {
            var news = _db.News.FirstOrDefault(u => u.Id == id);
            return news;
        }

    }
}
