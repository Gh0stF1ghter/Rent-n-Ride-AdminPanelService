using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Commands.VehicleCommands.UpdateVehicle;

public sealed class UpdateVehicleHandler : IRequestHandler<UpdateVehicleCommand, VehicleModel>
{
    public Task<VehicleModel> Handle(UpdateVehicleCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}