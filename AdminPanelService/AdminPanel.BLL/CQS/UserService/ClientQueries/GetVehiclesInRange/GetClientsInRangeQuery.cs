using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.UserService.ClientQueries.GetVehiclesInRange;

public sealed record GetClientsInRangeQuery(int Page, int PageSize) : IRequest<IEnumerable<ClientModel>>;