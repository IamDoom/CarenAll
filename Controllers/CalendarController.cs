using CarenAll.data;
using Microsoft.AspNetCore.Mvc;

namespace CarenAll.Controllers
{
    [ApiController]
    public class CalendarController : Controller
    {
        private readonly AppDbContext _appdbcontext;

        public CalendarController(AppDbContext appdbcontext)
        {
            _appdbcontext = appdbcontext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAvailableDates()
        {

        }


    }
}
