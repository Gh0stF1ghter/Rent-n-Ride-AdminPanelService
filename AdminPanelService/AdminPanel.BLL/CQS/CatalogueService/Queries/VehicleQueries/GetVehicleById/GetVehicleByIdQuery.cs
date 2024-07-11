using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Queries.VehicleQueries.GetVehicleById;

public sealed record GetVehicleByIdQuery(Guid Id) : IRequest<VehicleModel>;