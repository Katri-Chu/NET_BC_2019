using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsPortal.Logic;

namespace NewsPortal.Controllers
{
    public class TopicController : Controller
    {
        private NewsManager _manager;

        public TopicController(NewsManager manager)
        {
            _manager = manager;
        }
        public IActionResult Index()
        {
            var news = _manager.GetByCategory();
            return View();
        }
    }
}