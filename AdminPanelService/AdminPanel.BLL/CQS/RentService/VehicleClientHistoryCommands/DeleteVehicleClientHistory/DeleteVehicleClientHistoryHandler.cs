using MediatR;

namespace AdminPanel.BLL.CQS.RentService.VehicleClientHistoryCommands.DeleteVehicleClientHistory;

public sealed class DeleteVehicleClientHistoryHandler : IRequestHandler<DeleteVehicleClientHistoryCommand>
{
    public Task Handle(DeleteVehicleClientHistoryCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}