using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Commands.VehicleCommands.AddVehicle;

public sealed class AddVehicleHandler : IRequestHandler<AddVehicleCommand, VehicleModel>
{
    public Task<VehicleModel> Handle(AddVehicleCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}