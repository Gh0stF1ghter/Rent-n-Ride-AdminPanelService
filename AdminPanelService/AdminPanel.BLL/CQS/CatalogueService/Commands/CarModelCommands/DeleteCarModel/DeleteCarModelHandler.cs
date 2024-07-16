using EventBus.CatalogueServiceEvents.CarModelEvents;
using MassTransit;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Commands.CarModelCommands.DeleteCarModel;

public sealed class DeleteCarModelHandler(IPublishEndpoint publishEndpoint) : IRequestHandler<DeleteCarModelCommand>
{
    public async Task Handle(DeleteCarModelCommand command, CancellationToken cancellationToken)
    {
        await publishEndpoint.Publish(new CarModelDeleted(command.Id), cancellationToken);
    }
}