using EventBus.UserEvents;
using Mapster;
using MassTransit;
using MediatR;

namespace AdminPanel.BLL.CQS.UserService.ClientCommands.UpdateClient;

public sealed class UpdateClientHandler(IPublishEndpoint publishEndpoint) : IRequestHandler<UpdateClientCommand>
{
    public async Task Handle(UpdateClientCommand command, CancellationToken cancellationToken)
    {
        var userToUpdate = command.UpdatedModel.Adapt<UserUpdated>();

        await publishEndpoint.Publish(userToUpdate, cancellationToken);
    }
}