using EventBus.CatalogueServiceEvents.CarModelEvents;
using Mapster;
using MassTransit;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Commands.CarModelCommands.AddCarModel;

public sealed class AddCarModelHandler(IPublishEndpoint publishEndpoint) : IRequestHandler<AddCarModelCommand>
{
    public async Task Handle(AddCarModelCommand command, CancellationToken cancellationToken)
    {
        var carModelToAdd = command.NewModel.Adapt<CarModelCreated>();

        await publishEndpoint.Publish(carModelToAdd, cancellationToken);
    }
}