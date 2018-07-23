using Kospa.Data.Context;
using Kospa.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Kospa.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<JsonResult> GetMeetings()
        {
            await Task.Delay(500);
            var vm = MeetingContext.Meetings.Select(i => new MeetingViewModel
            {
                Id = i.Id,
                Title = i.Title,
                MeetingDate = i.Date,
                ParticipantCount = i.Users.Count
            }).ToList();
            return Json(vm);
        }

        public async Task<JsonResult> GetMeetingById(int id)
        {
            await Task.Delay(500);
            var vm = MeetingContext.Meetings.FirstOrDefault(i => i.Id == id);
            if (vm == null)
            {
                return null;
            }
            return Json(new { Id = vm.Id, Date = vm.Date.ToString(), Title = vm.Title, Users = vm.Users.ToList() });
        }

        public IActionResult Participants()
        {
            return View();
        }
    }
}