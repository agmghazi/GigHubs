using GigHub.Dtos;
using GigHub.Models;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Http;

namespace GigHub.Controllers
{
    public class FollwingsController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public FollwingsController()
        {
            _context = new ApplicationDbContext();
        }


        public IHttpActionResult Follow(FollowingDto dto)
        {
            var userId = User.Identity.GetUserId();
            if (_context.Followings.Any(x => x.FolloweeId == userId && x.FolloweeId == dto.FolloweeId))
                return BadRequest("Following already exists.");
            var following = new Following
            {
                FolloweeId = userId,
                FollowerId = dto.FolloweeId
            };
            _context.Followings.Add(following);
            _context.SaveChanges();

            return Ok();
        }
    }
}
