using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.UserService.ClientQueries.GetVehicleById;

public sealed record GetClientByIdQuery(Guid Id) : IRequest<ClientModel>;