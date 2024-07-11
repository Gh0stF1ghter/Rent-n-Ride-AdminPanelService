using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.UserService.ClientCommands.AddClient;

public sealed record AddClientCommand(ClientModel NewModel) : IRequest<ClientModel>;