using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.RentService.VehicleClientHistoryCommands.AddVehicleClientHistory;

public sealed class AddVehicleClientHistoryHandler : IRequestHandler<AddVehicleClientHistoryCommand, VehicleClientHistoryModel>
{
    public Task<VehicleClientHistoryModel> Handle(AddVehicleClientHistoryCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}