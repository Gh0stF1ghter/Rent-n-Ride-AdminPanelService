using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Commands.ManufacturerCommands.UpdateManufacturer;

public sealed class UpdateManufacturerHandler : IRequestHandler<UpdateManufacturerCommand, ManufacturerModel>
{
    public Task<ManufacturerModel> Handle(UpdateManufacturerCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}