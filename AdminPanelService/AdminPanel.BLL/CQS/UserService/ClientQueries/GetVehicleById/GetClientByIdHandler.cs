using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.UserService.ClientQueries.GetVehicleById;

public sealed class GetClientByIdHandler : IRequestHandler<GetClientByIdQuery, ClientModel>
{
    public Task<ClientModel> Handle(GetClientByIdQuery query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}