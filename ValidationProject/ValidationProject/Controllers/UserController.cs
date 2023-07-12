using Microsoft.AspNetCore.Mvc;
using ValidationProject.Models;

namespace ValidationProject.Controllers
{
    public class UserController : Controller
    {

        private static readonly List<UserViewModel> _users = new ();

        [HttpGet]
        public IActionResult Index()
        {
            return RedirectToAction(nameof(List));
        }
        [HttpGet]
        public IActionResult List()
        {
            return View(_users);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([FromForm]UserViewModel user)
        {
            user.Id = _users.Count;
            _users.Add(user);
            ViewData["UserAdded"] = true;
       
            return View();
        }
    }
}
