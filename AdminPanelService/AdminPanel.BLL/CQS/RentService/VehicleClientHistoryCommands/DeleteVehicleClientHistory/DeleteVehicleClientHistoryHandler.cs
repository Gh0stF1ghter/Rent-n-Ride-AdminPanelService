using EventBus.VehicleClientHistoryEvents;
using MassTransit;
using MediatR;

namespace AdminPanel.BLL.CQS.RentService.VehicleClientHistoryCommands.DeleteVehicleClientHistory;

public sealed class DeleteVehicleClientHistoryHandler(IPublishEndpoint publishEndpoint) : IRequestHandler<DeleteVehicleClientHistoryCommand>
{
    public async Task Handle(DeleteVehicleClientHistoryCommand command, CancellationToken cancellationToken)
    {
        await publishEndpoint.Publish(new VehicleClientHistoryDeleted(command.Id), cancellationToken);
    }
}