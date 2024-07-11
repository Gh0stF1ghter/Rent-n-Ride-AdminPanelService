using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Commands.ManufacturerCommands.AddManufacturer;

public sealed record AddManufacturerCommand(ManufacturerModel NewModel) : IRequest<ManufacturerModel>;