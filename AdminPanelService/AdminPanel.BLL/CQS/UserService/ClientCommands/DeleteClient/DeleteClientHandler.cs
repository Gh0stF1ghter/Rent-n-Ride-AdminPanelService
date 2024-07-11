using MediatR;

namespace AdminPanel.BLL.CQS.UserService.ClientCommands.DeleteClient;

public sealed class DeleteClientHandler : IRequestHandler<DeleteClientCommand>
{
    public Task Handle(DeleteClientCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}