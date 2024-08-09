using AdminPanel.BLL.Models;
using EventBus.VehicleClientHistoryEvents;
using Mapster;
using MassTransit;
using MediatR;

namespace AdminPanel.BLL.CQS.RentService.VehicleClientHistoryCommands.AddVehicleClientHistory;

public sealed class AddVehicleClientHistoryHandler(IPublishEndpoint publishEndpoint) : IRequestHandler<AddVehicleClientHistoryCommand>
{
    public async Task Handle(AddVehicleClientHistoryCommand command, CancellationToken cancellationToken)
    {
        var vehicleClientHistoryToAdd = command.NewModel.Adapt<VehicleClientHistoryCreated>();

        await publishEndpoint.Publish(vehicleClientHistoryToAdd, cancellationToken);
    }
}