using EventBus.CatalogueServiceEvents.ManufacturerEvents;
using Mapster;
using MassTransit;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Commands.ManufacturerCommands.AddManufacturer;

public sealed class AddManufacturerHandler(IPublishEndpoint publishEndpoint) : IRequestHandler<AddManufacturerCommand>
{
    public async Task Handle(AddManufacturerCommand command, CancellationToken cancellationToken)
    {
        var carModelToAdd = command.NewModel.Adapt<ManufacturerCreated>();

        await publishEndpoint.Publish(carModelToAdd, cancellationToken);
    }
}