using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Queries.VehicleQueries.GetVehicleById;

public sealed record GetClientByIdQuery(Guid Id) : IRequest<ClientModel>;