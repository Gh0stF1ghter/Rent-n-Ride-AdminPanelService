using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.RentService.VehicleClientHistoryCommands.UpdateVehicleClientHistory;

public sealed class UpdateVehicleClientHistoryHandler : IRequestHandler<UpdateVehicleClientHistoryCommand, VehicleClientHistoryModel>
{
    public Task<VehicleClientHistoryModel> Handle(UpdateVehicleClientHistoryCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}