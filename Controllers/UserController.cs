using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MriduBooks.Data;
using MriduBooks.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MriduBooks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly BookDbContext _db;

        public UserController(BookDbContext db)
        {
            _db = db;
        }

        // GET: api/User
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _db.Users.ToListAsync();
        }

        // GET api/<UserController>/5

        // GET: api/book/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _db.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // POST api/<User>
        [HttpPost]
        public async Task<ActionResult<User>> PostDCandidate(User user)
        {
            _db.Users.Add(user);
            await _db.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.Id}, user);
        }

    }
}
