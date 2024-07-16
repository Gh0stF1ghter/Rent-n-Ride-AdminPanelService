using EventBus.CatalogueServiceEvents.VehicleEvents;
using Mapster;
using MassTransit;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Commands.VehicleCommands.AddVehicle;

public sealed class AddVehicleHandler(IPublishEndpoint publishEndpoint) : IRequestHandler<AddVehicleCommand>
{
    public async Task Handle(AddVehicleCommand command, CancellationToken cancellationToken)
    {
        var carModelToAdd = command.NewModel.Adapt<VehicleCreated>();

        await publishEndpoint.Publish(carModelToAdd, cancellationToken);
    }
}