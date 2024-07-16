using EventBus.UserEvents;
using Mapster;
using MassTransit;
using MediatR;

namespace AdminPanel.BLL.CQS.UserService.ClientCommands.DeleteClient;

public sealed class DeleteClientHandler(IPublishEndpoint publishEndpoint) : IRequestHandler<DeleteClientCommand>
{
    public async Task Handle(DeleteClientCommand command, CancellationToken cancellationToken)
    {
        await publishEndpoint.Publish(new UserDeleted(command.Id), cancellationToken);
    }
}