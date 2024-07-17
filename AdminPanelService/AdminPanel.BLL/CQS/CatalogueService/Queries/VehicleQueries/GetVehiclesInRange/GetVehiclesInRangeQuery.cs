using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Queries.VehicleQueries.GetVehiclesInRange;

public sealed record GetVehiclesInRangeQuery(int Page, int PageSize) : IRequest<IEnumerable<VehicleModel>>;