using Microsoft.AspNetCore.Mvc;
using CarenAll.data;
using CarenAll.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore.Query;

namespace CarenAll.Controllers
{
    public class LeaseController : Controller
    {

        private readonly AppDbContext _appDbContext;

        public LeaseController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost("InitialRequest")]
        public IActionResult InitiateLeaseRequest([FromBody] Voertuigen Voertuigdto, [FromBody] User userdto)
        {
            /* if (Voertuigdto == null || userdto == null)
            {
                return BadRequest("Invalid vehicle or user data.");

            } */

            var partialrequest = new LeaseRequest
            {
                RequestorID = userdto.Id,
                VehicleID = Voertuigdto.Id,
                Requestor = userdto,
                Vehicle = Voertuigdto,
                Status = "Draft", // Initial status indicating it's incomplete
                StartDate = DateTime.MinValue, // Placeholder to be filled later
                EndDate = DateTime.MinValue,   // Placeholder to be filled later
                RequestReason = "",            // Placeholder
                ExpectedDistanceInKM = 0
            };
         
            return Ok(partialrequest);
        }
        [HttpGet]
        public IActionResult GetLeaseRequests()
        {
            var leaserequests = _appDbContext.LeaseRequests
            .Select(e => new
            {
                e.RequestorID,
                e.RequestorCompanyID,
                e.VehicleID

            })
             .ToList(); 
            //gotta finish this properly to display the proper info for employees
            return Json(leaserequests);
        }

        public IActionResult CreateLeaseRequest([FromBody] LeaseRequest requestdto)
        {

            return Ok();
        }
        
        
    }
}
