using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppTrain.Models;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using WebAppTrain.Controllers.Resources;

namespace WebAppTrain.Controllers
{
    [Produces("application/json")]
    [Route("api/Makes")]
    public class MakesController : Controller
    {
        private readonly AppDbContext context;
        private readonly IMapper mapper;

        public MakesController(AppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        //[HttpGet("/api/makes")]
        //public async Task<IEnumerable<MakeResource>> GetMakes()
        //{
        //    var makes = await context.Makes.Include(m => m.Models).ToListAsync();

        //    return mapper.Map<List<Make>, List<MakeResource>>(makes);
        //}
    }
}