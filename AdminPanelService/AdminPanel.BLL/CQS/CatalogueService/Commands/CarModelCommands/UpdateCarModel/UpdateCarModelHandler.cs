using EventBus.CatalogueServiceEvents.CarModelEvents;
using Mapster;
using MassTransit;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Commands.CarModelCommands.UpdateCarModel;

public sealed class UpdateCarModelHandler(IPublishEndpoint publishEndpoint) : IRequestHandler<UpdateCarModelCommand>
{
    public async Task Handle(UpdateCarModelCommand command, CancellationToken cancellationToken)
    {
        var carModelToUpdate = command.UpdatedModel.Adapt<CarModelUpdated>();

        await publishEndpoint.Publish(carModelToUpdate, cancellationToken);
    }
}