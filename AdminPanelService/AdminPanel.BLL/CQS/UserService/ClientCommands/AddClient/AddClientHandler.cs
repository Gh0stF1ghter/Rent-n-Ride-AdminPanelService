using EventBus;
using Mapster;
using MassTransit;
using MediatR;

namespace AdminPanel.BLL.CQS.UserService.ClientCommands.AddClient;

public sealed class AddClientHandler(IPublishEndpoint publishEndpoint) : IRequestHandler<AddClientCommand>
{
    public async Task Handle(AddClientCommand command, CancellationToken cancellationToken)
    {
        var userToSend = command.NewModel.Adapt<UserCreated>();

        await publishEndpoint.Publish(userToSend, cancellationToken);

        await Console.Out.WriteLineAsync($"user {userToSend.Email} published");
    }
}