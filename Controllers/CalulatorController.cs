using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatRSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalulatorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CalulatorController(IMediator mediator) => _mediator = mediator;

        [HttpGet("Multiply")]
        public async Task<int> Multiply(int val1, int val2)
        {
            MultiplyRequest request = new MultiplyRequest() {Val1 = val1, Val2 = val2 };
            return await _mediator.Send(request);
        }
        
        [HttpGet("Divide")]
        public async Task<double> Divide(int val1, int val2)
        {
            DivideRequest request = new DivideRequest() {Val1 = val1, Val2 = val2 };
            return await _mediator.Send(request);
        }
    }

}