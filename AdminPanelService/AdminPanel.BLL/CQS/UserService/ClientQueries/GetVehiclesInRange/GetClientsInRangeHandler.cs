using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.UserService.ClientQueries.GetVehiclesInRange;

public sealed class GetClientsInRangeHandler : IRequestHandler<GetClientsInRangeQuery, IEnumerable<ClientModel>>
{
    public Task<IEnumerable<ClientModel>> Handle(GetClientsInRangeQuery query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}