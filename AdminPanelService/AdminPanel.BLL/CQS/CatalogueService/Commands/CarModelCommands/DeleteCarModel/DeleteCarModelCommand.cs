using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Commands.CarModelCommands.DeleteCarModel;

public sealed record DeleteCarModelCommand(Guid Id) : IRequest;