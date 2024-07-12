using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Commands.ManufacturerCommands.DeleteManufacturer;

public sealed record DeleteManufacturerCommand(Guid Id) : IRequest;