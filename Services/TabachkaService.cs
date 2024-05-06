using GigichTask_MySolution_.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GigichTask_MySolution_.Services
{
    public class TabachkaService : ControllerBase
    {
        private readonly TabachkaContext _context;

        public TabachkaService(TabachkaContext context)
        {
            _context = context;
        }
    }
}
