using GigichTask_MySolution_.Data;
using GigichTask_MySolution_.Models;
using GigichTask_MySolution_.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GigichTask_MySolution_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TabachkaController : ControllerBase
    {
        private readonly TabachkaService _tabachkaService;

        public TabachkaController(TabachkaService tabachkaService)
        {
            _tabachkaService = tabachkaService;
        }

        [HttpGet]
        public async Task<ActionResult<Tabachka>> GetAllTovar()
        {
            return Ok(await _tabachkaService.GetTabachkas());
        }
    }
}
