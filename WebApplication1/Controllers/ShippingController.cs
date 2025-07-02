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
    public class ShippingController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ShippingController(AppDbContext context) => _context = context;

        [HttpGet("pending")]
        public IActionResult GetPendingOrders() => Ok(_context.Orders.Where(o => o.Status == "pending").ToList());

        [HttpPost("{orderId}/ship")]
        public IActionResult ConfirmShipping(int orderId, [FromBody] ShippingRequest request)
        {
            var order = _context.Orders.Find(orderId);
            if (order == null) return NotFound();

            _context.Shipping.Add(new Shipping
            {
                OrderId = orderId,
                TrackingNumber = request.TrackingNumber,
                Courier = request.Courier,
                Status = "shipped"
            });

            order.Status = "shipped";
            _context.SaveChanges();
            return Ok();
        }
    }
}
