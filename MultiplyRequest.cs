using MediatR;
namespace MediatRSample
{

    public class MultiplyRequest : IRequest<int>
    {
        public int Val1 { get; set; }
        public int Val2 { get; set; }
    }

}