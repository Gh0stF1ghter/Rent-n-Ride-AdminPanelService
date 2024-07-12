using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Commands.CarModelCommands.UpdateCarModel;

public sealed class UpdateCarModelHandler : IRequestHandler<UpdateCarModelCommand, CarModel>
{
    public Task<CarModel> Handle(UpdateCarModelCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}