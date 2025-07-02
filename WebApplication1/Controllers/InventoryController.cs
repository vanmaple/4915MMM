using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Data;
using SDP_EntityModels;

namespace WebApplication1.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly AppDbContext _context;
        public InventoryController(AppDbContext context) => _context = context;


        [HttpGet("warning")]
        public IActionResult GetLowStockProducts() =>
            Ok(_context.Products.Where(p => p.Stock < p.MinimumStockLevel).ToList());

        [HttpPost("adjust")]
        public IActionResult AdjustInventory([FromBody] InventoryAdjustRequest request)
        {
            var product = _context.Products.Find(request.ProductId);
            if (product == null) return NotFound();

            product.Stock += request.AdjustAmount;

            _context.InventoryLogs.Add(new InventoryLog
            {
                ProductId = product.Id,
                ChangeAmount = request.AdjustAmount,
                Reason = request.Reason,
                AdminId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier))
            });

            _context.SaveChanges();
            return Ok();
        }
    }
}
