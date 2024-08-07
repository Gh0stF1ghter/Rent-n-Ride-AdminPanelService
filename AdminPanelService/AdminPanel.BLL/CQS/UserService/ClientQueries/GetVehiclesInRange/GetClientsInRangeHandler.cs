using AdminPanel.BLL.Models;
using ClientGrpcService;
using Mapster;
using MediatR;

namespace AdminPanel.BLL.CQS.UserService.ClientQueries.GetVehiclesInRange;

public sealed class GetClientsInRangeHandler(ClientGrpcService.ClientService.ClientServiceClient client) : IRequestHandler<GetClientsInRangeQuery, IEnumerable<ClientModel>>
{
    public async Task<IEnumerable<ClientModel>> Handle(GetClientsInRangeQuery query, CancellationToken cancellationToken)
    {
        var request = new GetClientsInRangeRequest
        {
            PageNumber = query.Page,
            PageSize = query.PageSize,
        };

        var response = await client.GetClientsAsync(request, cancellationToken: cancellationToken);

        var clientModels = response.Clients.Adapt<IEnumerable<ClientModel>>();

        return clientModels;
    }
}