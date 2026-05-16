using Microsoft.AspNetCore.Mvc;
using Wallet.Application.Interfaces;

namespace Wallet.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WalletController : ControllerBase
    {
        private readonly IWalletService _service;

        public WalletController(IWalletService service)
        {
            _service = service;
        }

        [HttpPost("create")]
        public IActionResult Create(string user)
        {
            return Ok(_service.Create(user));
        }

        [HttpPost("credit")]
        public IActionResult Credit(int id, decimal amount)
        {
            return Ok(_service.Credit(id, amount));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.Get(id));
        }

        [HttpGet("cicd-test")]
        public IActionResult CicdTest()
        {
            return Ok(new
            {
                message = "CI/CD pipeline is working 🚀",
                time = DateTime.UtcNow,
                status = "success"
            });
        }
    }
}