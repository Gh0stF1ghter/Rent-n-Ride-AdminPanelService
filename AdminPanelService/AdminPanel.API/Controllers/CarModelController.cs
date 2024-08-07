using AdminPanel.BLL.CQS.CatalogueService.Commands.CarModelCommands.AddCarModel;
using AdminPanel.BLL.CQS.CatalogueService.Commands.CarModelCommands.DeleteCarModel;
using AdminPanel.BLL.CQS.CatalogueService.Commands.CarModelCommands.UpdateCarModel;
using AdminPanel.BLL.CQS.CatalogueService.Queries.CarModelQueries.GetCarModelById;
using AdminPanel.BLL.CQS.CatalogueService.Queries.CarModelQueries.GetCarModelsInRange;
using EventBus.CatalogueServiceEvents.CarModelEvents;
using Microsoft.AspNetCore.Authorization;

namespace AdminPanel.API.Controllers;

[ApiController]
[Authorize("use:dashboard")]
[Route("api/model")]
public class CarModelController(ISender sender) : ControllerBase
{
    [HttpGet]
    [ActionName("GetAllCarModelsInRange")]
    public async Task<IEnumerable<CarModelViewModel>> GetAll([FromQuery] int page = 1, [FromQuery] int pageSize = 10, CancellationToken cancellationToken = default)
    {
        var carModels = await sender.Send(new GetCarModelsInRangeQuery(page, pageSize), cancellationToken);

        var carModelsVMS = carModels.Adapt<IEnumerable<CarModelViewModel>>();

        return carModelsVMS;
    }

    [HttpGet("{id}")]
    [ActionName("GetCarModelById")]
    public async Task<CarModelViewModel> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var carModel = await sender.Send(new GetCarModelByIdQuery(id), cancellationToken);

        var newCarModel = carModel.Adapt<CarModelViewModel>();

        return newCarModel;
    }

    [HttpPost]
    [ActionName("CreateCarModel")]
    public async Task<CarModelViewModel> Create([FromBody] ShortCarModelViewModel createCarModelViewModel, CancellationToken cancellationToken)
    {
        var carModel = createCarModelViewModel.Adapt<CarModel>();

        var newCarModel = await sender.Send(new AddCarModelCommand(carModel), cancellationToken);

        var carModelVM = newCarModel.Adapt<CarModelViewModel>();

        return carModelVM;
    }

    [HttpPut("{id}")]
    [ActionName("UpdateCarModelById")]
    public async Task<CarModelViewModel> Update([FromRoute] Guid id, [FromBody] ShortCarModelViewModel updateCarModelViewModel, CancellationToken cancellationToken)
    {
        var carModel = updateCarModelViewModel.Adapt<CarModel>();
        carModel.Id = id;

        var newCarModel = await sender.Send(new UpdateCarModelCommand(carModel), cancellationToken);

        var carModelViewModel = newCarModel.Adapt<CarModelViewModel>();

        return carModelViewModel;
    }

    [HttpDelete("{id}")]
    [ActionName("DeleteCarModelById")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await sender.Send(new DeleteCarModelCommand(id), cancellationToken);
    }
}