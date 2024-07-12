using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Commands.ManufacturerCommands.AddManufacturer;

public sealed class AddManufacturerHandler : IRequestHandler<AddManufacturerCommand, ManufacturerModel>
{
    public Task<ManufacturerModel> Handle(AddManufacturerCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}