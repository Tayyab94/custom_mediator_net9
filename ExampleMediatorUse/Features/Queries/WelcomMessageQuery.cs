using MyCustomerMediator;

namespace ExampleMediatorUse.Features.Queries
{
    public class WelcomMessageQuery : IRequest<string>
    {
        public string Name { get; set; }
    }

    public class WelcomMessageQueryHandler: IRequestHandler<WelcomMessageQuery, string>
    {
        public Task<string> Handle(WelcomMessageQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult($"Welcome {request.Name}");
        }
    }
}
