using EventBus.CatalogueServiceEvents.ManufacturerEvents;
using MassTransit;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Commands.ManufacturerCommands.DeleteManufacturer;

public sealed class DeleteManufacturerHandler(IPublishEndpoint publishEndpoint) : IRequestHandler<DeleteManufacturerCommand>
{
    public async Task Handle(DeleteManufacturerCommand command, CancellationToken cancellationToken)
    {
        await publishEndpoint.Publish(new ManufacturerDeleted(command.Id), cancellationToken);
    }
}