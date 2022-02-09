using MediatR;
namespace MediatRSample
{

    public class DivideRequest : IRequest<double>
    {
        public int Val1 { get; set; }
        public int Val2 { get; set; }
    }

}