using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.UserService.ClientCommands.AddClient;

public sealed class AddClientHandler : IRequestHandler<AddClientCommand, ClientModel>
{
    public Task<ClientModel> Handle(AddClientCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}