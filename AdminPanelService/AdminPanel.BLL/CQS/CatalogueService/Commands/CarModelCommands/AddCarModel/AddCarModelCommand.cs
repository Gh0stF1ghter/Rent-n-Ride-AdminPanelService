using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Commands.CarModelCommands.AddCarModel;

public sealed record AddCarModelCommand(CarModel NewModel) : IRequest;