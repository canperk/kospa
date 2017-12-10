using Kospa.Data.Context;
using Kospa.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Kospa.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetMeetings()
        {
            var vm = MeetingContext.Meetings.Select(i => new MeetingViewModel
            {
                Id = i.Id,
                Title = i.Title,
                MeetingDate = i.Date,
                ParticipantCount = i.Users.Count
            }).ToList();
            return Json(vm);
        }

        public IActionResult Participants()
        {
            return View();
        }
    }
}