using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.UserService.ClientQueries.GetVehiclesInRange;

public sealed class GetClientsInRangeQuery(int page, int pageSize) : IRequest<IEnumerable<ClientModel>>;