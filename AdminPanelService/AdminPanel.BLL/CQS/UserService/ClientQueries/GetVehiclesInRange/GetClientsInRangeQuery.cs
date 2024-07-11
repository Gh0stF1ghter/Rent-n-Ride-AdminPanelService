using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Queries.VehicleQueries.GetVehiclesInRange;

public sealed class GetClientsInRangeQuery(int page, int pageSize) : IRequest<IEnumerable<ClientModel>>;