using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Commands.CarModelCommands.UpdateCarModel;

public sealed record UpdateCarModelCommand(CarModel UpdatedModel) : IRequest<CarModel>;