using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.UserService.ClientCommands.UpdateClient;

public sealed record UpdateClientCommand(ClientModel UpdatedModel) : IRequest<ClientModel>;