using AdminPanel.BLL.Models;
using ClientGrpcService;
using Mapster;
using MediatR;

namespace AdminPanel.BLL.CQS.UserService.ClientQueries.GetVehicleById;

public sealed class GetClientByIdHandler(ClientGrpcService.ClientService.ClientServiceClient client) : IRequestHandler<GetClientByIdQuery, ClientModel>
{
    public async Task<ClientModel> Handle(GetClientByIdQuery query, CancellationToken cancellationToken)
    {
        var request = new GetClientRequest
        {
            Id = query.Id.ToString()
        };

        var response = await client.GetClientAsync(request, cancellationToken: cancellationToken);

        var clientModel = response.Client.Adapt<ClientModel>();

        return clientModel;
    }
}