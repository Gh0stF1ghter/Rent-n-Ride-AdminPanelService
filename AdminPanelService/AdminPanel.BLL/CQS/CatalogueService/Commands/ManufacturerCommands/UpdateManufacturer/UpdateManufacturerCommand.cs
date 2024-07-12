using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Commands.ManufacturerCommands.UpdateManufacturer;

public sealed record UpdateManufacturerCommand(ManufacturerModel UpdatedModel) : IRequest<ManufacturerModel>;