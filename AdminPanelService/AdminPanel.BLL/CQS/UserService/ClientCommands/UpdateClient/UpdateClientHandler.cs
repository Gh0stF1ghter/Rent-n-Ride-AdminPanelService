using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.UserService.ClientCommands.UpdateClient;

public sealed class UpdateClientHandler : IRequestHandler<UpdateClientCommand, ClientModel>
{
    public Task<ClientModel> Handle(UpdateClientCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}