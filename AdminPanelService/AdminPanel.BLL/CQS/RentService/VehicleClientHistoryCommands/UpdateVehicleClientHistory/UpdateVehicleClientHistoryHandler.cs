using AdminPanel.BLL.Models;
using EventBus.VehicleClientHistoryEvents;
using Mapster;
using MassTransit;
using MediatR;

namespace AdminPanel.BLL.CQS.RentService.VehicleClientHistoryCommands.UpdateVehicleClientHistory;

public sealed class UpdateVehicleClientHistoryHandler(IPublishEndpoint publishEndpoint) : IRequestHandler<UpdateVehicleClientHistoryCommand>
{
    public async Task Handle(UpdateVehicleClientHistoryCommand command, CancellationToken cancellationToken)
    {
        var vehicleClientHostoryToUpdate = command.UpdatedModel.Adapt<VehicleClientHistoryUpdated>();

        await publishEndpoint.Publish(vehicleClientHostoryToUpdate, cancellationToken);
    }
}