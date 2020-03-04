using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using web_api_testing.Models;
using web_api_testing.Persistence;

namespace web_api_testing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedController : ControllerBase
    {
        private readonly BlogContext _context;

        public FeedController(BlogContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Get()
        {
            _context.Feeds.Add(new Feed
            {
                name = "hello",
                title = "world"
            });

            _context.SaveChanges();

    
            return Ok(_context.Feeds);
        }
    }
}