using Microsoft.AspNetCore.Mvc;
using API.Calc.Mgr;
using API.Calc.Model;

namespace API.Calc.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        private CalculateMgr calcMgr = new CalculateMgr();

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Calculator Add(int value1, int value2)
        {
            Calculator Addition = new Calculator
            {
                Value1 = value1,
                Value2 = value2,
                Result = calcMgr.Add(value1, value2)
            };
            return Addition;
        }

        [HttpGet]
        public Calculator Subtract(int value1, int value2)
        {
            Calculator Subtraction = new Calculator
            {
                Value1 = value1,
                Value2 = value2,
                Result = calcMgr.Subtract(value1, value2)
            };
            return Subtraction;
        }

        [HttpGet]
        public Calculator Multiply(int value1, int value2)
        {
            Calculator Multiplication = new Calculator
            {
                Value1 = value1,
                Value2 = value2,
                Result = calcMgr.Multiply(value1, value2)
            };
            return Multiplication;
        }

        [HttpGet]
        public Calculator Divide(int value1, int value2)
        {
            Calculator Division = new Calculator
            {
                Value1 = value1,
                Value2 = value2,
                Result = calcMgr.Divide(value1, value2)
            };
            return Division;
        }
    }
}