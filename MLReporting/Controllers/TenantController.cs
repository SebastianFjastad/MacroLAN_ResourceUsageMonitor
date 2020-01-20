using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using MLReporting.Domain.Abstract;
using MLReporting.Domain.Model;
using MLReporting.Models;

namespace MLReporting.Controllers
{
    public class TenantController : Controller
    {
        private ITenantRepository _repo;

        public TenantController(ITenantRepository repo)
        {
            _repo = repo;
        }

        public ActionResult Index()
        {
            var viewModel = new UsersViewModel { Users = _repo.GetUsers() };

            return View(viewModel);
        }

        public ActionResult UserReport(int id)
        {
            var users = _repo.GetUsers();
            var viewModel = new UsageViewModel
            {
                Users = users,
                User = users.FirstOrDefault(u => u.UserRoleDimKey == id),
            };

            return View(viewModel);
        }

        public PartialViewResult Report(int id, int fromDate, int toDate)
        {
            var viewModel = new UsageViewModel
            {
                User = _repo.GetUsers().FirstOrDefault(u => u.UserRoleDimKey == id),
                VMs = _repo.GetVMsByUserId(id),
                VMUsages = _repo.GetVMHourlyUsageByUserId(id, fromDate, toDate)
            };
            return PartialView(viewModel);
        }

        public ActionResult GetDateLastModified(int id)
        {
            var result = _repo.GetDateLastModified(id).VMLastModifiedDate;

            return Content(result != null ? result.ToString() : "");
        }
    }
}
