using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppTrain.Models;

namespace WebAppTrain.Controllers.Resources
{
    [Produces("application/json")]
    [Route("api/Postes")]
    public class PostesController : Controller
    {
        private readonly AppDbContext context;

        public PostesController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet("/api/posts")]
        public async Task<IEnumerable<Post>> GetPostes()
        {
            var postes = context.Posts.ToList();

            return postes;
        }
    }
}