using MediatR;

namespace AdminPanel.BLL.CQS.UserService.ClientCommands.DeleteClient;

public sealed record DeleteClientCommand(Guid Id) : IRequest;