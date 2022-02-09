using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MediatRSample
{
    public class DivideRequestHandler : IRequestHandler<DivideRequest, double>
    {
        public Task<double> Handle(DivideRequest request, CancellationToken cancellationToken)
        {            
            return Task.FromResult((double)request.Val1 / (double)request.Val2);
        }
    }

}