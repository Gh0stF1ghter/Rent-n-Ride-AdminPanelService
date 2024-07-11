using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Commands.ManufacturerCommands.DeleteManufacturer;

public sealed class DeleteManufacturerHandler : IRequestHandler<DeleteManufacturerCommand>
{
    public Task Handle(DeleteManufacturerCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}