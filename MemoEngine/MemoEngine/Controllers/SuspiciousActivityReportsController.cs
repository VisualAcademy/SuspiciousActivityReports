using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MemoEngine.Data;
using MemoEngine.Models;

namespace MemoEngine.Controllers
{
    public class SuspiciousActivityReportsController : Controller
    {
        private readonly TenantDbContext _context;

        public SuspiciousActivityReportsController(TenantDbContext context)
        {
            _context = context;
        }

        // GET: SuspiciousActivityReports
        public async Task<IActionResult> Index()
        {
            return View(await _context.SuspiciousActivityReports.ToListAsync());
        }

        // GET: SuspiciousActivityReports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suspiciousActivityReport = await _context.SuspiciousActivityReports
                .FirstOrDefaultAsync(m => m.Id == id);
            if (suspiciousActivityReport == null)
            {
                return NotFound();
            }

            return View(suspiciousActivityReport);
        }

        // GET: SuspiciousActivityReports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SuspiciousActivityReports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ReportCorrectionIndicator,Subject_Multiple,FirstName,MiddleInitial,LastName,AlsoKnownAs,DoingBusinessAs,Occupation,Address,City,State,ZIPCode,Country,DateOfBirth,GovtIssuedID_Type,GovtIssuedID_Number,GovtIssuedID_IssuingState,SSN,ITIN,EIN,AccountNumber,PhoneNumberHome,PhoneNumberWork,EmailAddress,VehicleLicenseNumber,VehicleLicenseState,CasinoAffiliation,BusinessRelationshipStatus,SuspiciousActivityType,SuspiciousActivityStartDate,SuspiciousActivityEndDate,SuspiciousActivityAmount,LawEnforcementContacted,ContactPersonName,ContactPersonPhone,ContactDate,ReportingCasinoTradeName,ReportingCasinoLegalName,CasinoAddress,CasinoCity,CasinoState,CasinoZIPCode,GamingInstitutionType,CasinoEIN,ContactLastName,ContactFirstName,ContactMiddleInitial,ContactTitle,ContactWorkPhone,ReportPreparedDate,NarrativeDescription")] SuspiciousActivityReport suspiciousActivityReport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(suspiciousActivityReport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(suspiciousActivityReport);
        }

        // GET: SuspiciousActivityReports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suspiciousActivityReport = await _context.SuspiciousActivityReports.FindAsync(id);
            if (suspiciousActivityReport == null)
            {
                return NotFound();
            }
            return View(suspiciousActivityReport);
        }

        // POST: SuspiciousActivityReports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ReportCorrectionIndicator,Subject_Multiple,FirstName,MiddleInitial,LastName,AlsoKnownAs,DoingBusinessAs,Occupation,Address,City,State,ZIPCode,Country,DateOfBirth,GovtIssuedID_Type,GovtIssuedID_Number,GovtIssuedID_IssuingState,SSN,ITIN,EIN,AccountNumber,PhoneNumberHome,PhoneNumberWork,EmailAddress,VehicleLicenseNumber,VehicleLicenseState,CasinoAffiliation,BusinessRelationshipStatus,SuspiciousActivityType,SuspiciousActivityStartDate,SuspiciousActivityEndDate,SuspiciousActivityAmount,LawEnforcementContacted,ContactPersonName,ContactPersonPhone,ContactDate,ReportingCasinoTradeName,ReportingCasinoLegalName,CasinoAddress,CasinoCity,CasinoState,CasinoZIPCode,GamingInstitutionType,CasinoEIN,ContactLastName,ContactFirstName,ContactMiddleInitial,ContactTitle,ContactWorkPhone,ReportPreparedDate,NarrativeDescription")] SuspiciousActivityReport suspiciousActivityReport)
        {
            if (id != suspiciousActivityReport.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(suspiciousActivityReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuspiciousActivityReportExists(suspiciousActivityReport.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(suspiciousActivityReport);
        }

        // GET: SuspiciousActivityReports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suspiciousActivityReport = await _context.SuspiciousActivityReports
                .FirstOrDefaultAsync(m => m.Id == id);
            if (suspiciousActivityReport == null)
            {
                return NotFound();
            }

            return View(suspiciousActivityReport);
        }

        // POST: SuspiciousActivityReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var suspiciousActivityReport = await _context.SuspiciousActivityReports.FindAsync(id);
            if (suspiciousActivityReport != null)
            {
                _context.SuspiciousActivityReports.Remove(suspiciousActivityReport);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuspiciousActivityReportExists(int id)
        {
            return _context.SuspiciousActivityReports.Any(e => e.Id == id);
        }
    }
}
