using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Commands.CarModelCommands.AddCarModel;

public sealed class AddCarModelHandler : IRequestHandler<AddCarModelCommand, CarModel>
{
    public Task<CarModel> Handle(AddCarModelCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}