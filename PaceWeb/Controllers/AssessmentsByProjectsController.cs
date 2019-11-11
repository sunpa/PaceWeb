using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PaceWeb.Data;
using PaceWeb.Models;

namespace PaceWeb.Controllers
{
    public class AssessmentsByProjectsController : Controller
    {
        private readonly PaceDbContext _db;
        
        public AssessmentsByProjectsController(PaceDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            string clientNo = "9008"; // for testing

            List<SelectListItem> bondSeriesFrom = new List<SelectListItem>();
            List<SelectListItem> bondSeriesTo = new List<SelectListItem>();

            var bondSeries = (from b in _db.BondSeries
                              where b.ClientNo == clientNo
                              orderby b.Name ascending
                              select b).AsQueryable();

            foreach (var item in bondSeries)
            {
                bondSeriesFrom.Add(new SelectListItem
                {
                    Text = item.Name.ToString(),
                    Value = item.Name.ToString()
                });
            }
            foreach (var item in bondSeries)
            {
                bondSeriesTo.Add(new SelectListItem
                {
                    Text = item.Name.ToString(),
                    Value = item.Name.ToString()
                });
            }

            this.ViewData["bondSeriesFrom"] = bondSeriesFrom;
            this.ViewData["bondSeriesTo"] = bondSeriesTo;

            this.ViewData["ClientNo"] = clientNo;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AssessmentsByProjects()
        {
            string clientNo = Request.Form["ClientNo"];
            string projectFrom = Request.Form["bondSeriesFrom"];
            string projectTo = Request.Form["bondSeriesTo"];

            var results = (from p in _db.Participants
                           join a in _db.Assessments on p.AccountNumber equals a.AccountNumber
                           join ad in _db.Address on p.AccountNumber equals ad.AccountNumber
                           join pi in _db.ProjectInfo on p.Project equals pi.ProjectNo
                           where p.Client == clientNo 
                           && pi.ProjectName.CompareTo(projectFrom) >= 0
                           && pi.ProjectName.CompareTo(projectTo) <= 0
                           select new AssessmentsByBondSeries
                           {
                               BondSeries = p.BondSeries,
                               ParticipantID = p.ParticipantID,
                               ParcelNo = ad.ParcelNo,
                               Name = p.EntityName,
                               FirstDueDate = a.FirstDueDate,
                               AssessmentAmount = a.AssessmentAmount,
                               InterestRate = a.InterestRate,
                               MaturityDate = a.MaturityDate,
                               PrincipalReceived = a.AssessmentReceived,
                               AdministrativeFee = a.AdminFee,
                               InterestPaidDate = a.InterestPaidDate,
                               NextDueDate = a.NextDueDate,
                               CurrentAssessmentAmount = a.CurrentAssessmentAmount,
                               InterestReceived = a.InterestReceived
                            }).ToListAsync();
                       
            return View(await results);
        }
    }
}