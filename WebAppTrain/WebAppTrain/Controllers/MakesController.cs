using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppTrain.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAppTrain.Controllers
{
    [Produces("application/json")]
    [Route("api/Makes")]
    public class MakesController : Controller
    {
        private readonly AppDbContext context;

        public MakesController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<Make>> GetMakes()
        {
            return await context.Makes.Include(m => m.Models).ToListAsync();
        }
    }
}