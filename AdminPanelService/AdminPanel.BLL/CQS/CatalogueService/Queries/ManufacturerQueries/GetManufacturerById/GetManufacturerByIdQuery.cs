using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Queries.ManufacturerQueries.GetManufacturerById;

public sealed record GetManufacturerByIdQuery(Guid Id) : IRequest<ManufacturerModel>;