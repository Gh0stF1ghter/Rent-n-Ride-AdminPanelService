using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Queries.VehicleQueries.GetVehiclesInRange;

public sealed class GetVehiclesInRangeQuery(int page, int pageSize) : IRequest<IEnumerable<VehicleModel>>;