using EventBus.CatalogueServiceEvents.ManufacturerEvents;
using Mapster;
using MassTransit;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Commands.ManufacturerCommands.UpdateManufacturer;

public sealed class UpdateManufacturerHandler(IPublishEndpoint publishEndpoint) : IRequestHandler<UpdateManufacturerCommand>
{
    public async Task Handle(UpdateManufacturerCommand command, CancellationToken cancellationToken)
    {
        var carModelToUpdate = command.UpdatedModel.Adapt<ManufacturerUpdated>();

        await publishEndpoint.Publish(carModelToUpdate, cancellationToken);
    }
}