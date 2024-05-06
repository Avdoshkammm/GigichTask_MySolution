using GigichTask_MySolution_.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GigichTask_MySolution_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TabachkaController : ControllerBase
    {
        private readonly TabachkaContext _dbContext;

        public TabachkaController(TabachkaContext dbContext)
        {
            _dbContext = dbContext;
        }


    }
}
