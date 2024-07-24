using HW_20_03_24.Models;
using Microsoft.AspNetCore.Mvc;
using HW_20_03_24.Models;

namespace HW_20_03_24.Controllers
{
    public class InvitationController : Controller
    {
        private static List<Invitation> Invitations = new List<Invitation>();

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Invitation invitation)
        {
            if (ModelState.IsValid) {
                Invitations.Add(invitation);
                return RedirectToAction("ThankYou");
            }
            return View(invitation);
        }

        public IActionResult ThankYou()
        {
            return View();
        }
    }
}
