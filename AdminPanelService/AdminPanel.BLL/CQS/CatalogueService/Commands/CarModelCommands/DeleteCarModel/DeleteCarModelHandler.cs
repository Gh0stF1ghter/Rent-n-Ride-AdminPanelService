using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Commands.CarModelCommands.DeleteCarModel;

public sealed class DeleteCarModelHandler : IRequestHandler<DeleteCarModelCommand>
{
    public Task Handle(DeleteCarModelCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}