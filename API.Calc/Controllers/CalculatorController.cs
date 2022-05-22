using Microsoft.AspNetCore.Mvc;
using API.Calc.Mgr;

namespace API.Calc.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        private Calculate calcMgr = new Calculate();

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public int Add(int value1, int value2)
        {
            return calcMgr.Add(value1, value2);
        }

        [HttpGet]
        public int Subtract(int value1, int value2)
        {
            return calcMgr.Subtract(value1, value2);
        }

        [HttpGet]
        public int Multiply(int value1, int value2)
        {
            return calcMgr.Multiply(value1, value2);
        }

        [HttpGet]
        public int Divide(int value1, int value2)
        {
            return calcMgr.Divide(value1, value2);
        }
    }
}