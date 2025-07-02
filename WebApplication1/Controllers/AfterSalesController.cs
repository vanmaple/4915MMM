using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Data;
using SDP_EntityModels;

namespace WebApplication1.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AfterSalesController : ControllerBase
    {
        private readonly AppDbContext _context;
        public AfterSalesController(AppDbContext context) => _context = context;

        [HttpPost]
        public IActionResult CreateRequest([FromBody] AfterSales request)
        {
            var claim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _context.AfterSales.Add(new AfterSales
            {
                OrderId = request.OrderId,
                Type = request.Type,
                Description = request.Description,
                Status = "pending"
            });
            _context.SaveChanges();
            return Ok();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("{id}/resolve")]
        public IActionResult ResolveRequest(int id, [FromBody] ResolveRequest request)
        {
            var record = _context.AfterSales.Find(id);
            if (record == null) return NotFound();

            record.Status = request.Approve ? "resolved" : "rejected";
            _context.SaveChanges();
            return Ok();
        }
    }
}
