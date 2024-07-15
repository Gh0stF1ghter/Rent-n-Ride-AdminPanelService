using AdminPanel.BLL.CQS.CatalogueService.Commands.CarModelCommands.AddCarModel;
using AdminPanel.BLL.CQS.CatalogueService.Commands.CarModelCommands.DeleteCarModel;
using AdminPanel.BLL.CQS.CatalogueService.Commands.CarModelCommands.UpdateCarModel;
using AdminPanel.BLL.CQS.CatalogueService.Queries.CarModelQueries.GetCarModelById;
using AdminPanel.BLL.CQS.CatalogueService.Queries.CarModelQueries.GetCarModelsInRange;

namespace AdminPanel.API.Controllers;

[ApiController]
[Route("api/model")]
public class CarModelController(ISender sender) : ControllerBase
{
    [HttpGet]
    [ActionName("GetAllModelNamesInRange")]
    public async Task<IEnumerable<CarModelViewModel>> GetAll([FromQuery] int page = 1, [FromQuery] int pageSize = 10, CancellationToken cancellationToken = default)
    {
        var modelNames = await sender.Send(new GetCarModelsInRangeQuery(page, pageSize), cancellationToken);

        var modelNamesVMs = modelNames.Adapt<IEnumerable<CarModelViewModel>>();

        return modelNamesVMs;
    }

    [HttpGet("{id}")]
    [ActionName("GetModelNameById")]
    public async Task<CarModelViewModel> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var modelName = await sender.Send(new GetCarModelByIdQuery(id), cancellationToken);

        var modelNameVM = modelName.Adapt<CarModelViewModel>();

        return modelNameVM;
    }

    [HttpPost]
    [ActionName("CreateModelName")]
    public async Task<CarModelViewModel> Create([FromBody] ShortCarModelViewModel createCarModelViewModel, CancellationToken cancellationToken)
    {
        var carModel = createCarModelViewModel.Adapt<CarModel>();

        var newModelName = await sender.Send(new AddCarModelCommand(carModel), cancellationToken);

        var modelNameVM = newModelName.Adapt<CarModelViewModel>();

        return modelNameVM;
    }

    [HttpPut("{id}")]
    [ActionName("UpdateModelNameById")]
    public async Task<CarModelViewModel> Update([FromRoute] Guid id, [FromBody] ShortCarModelViewModel updateCarModelViewModel, CancellationToken cancellationToken)
    {
        var carModel = updateCarModelViewModel.Adapt<CarModel>();
        carModel.Id = id;

        var newModelName = await sender.Send(new UpdateCarModelCommand(carModel), cancellationToken);

        var CarModelViewModel = newModelName.Adapt<CarModelViewModel>();

        return CarModelViewModel;
    }

    [HttpDelete("{id}")]
    [ActionName("DeleteModelNameById")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await sender.Send(new DeleteCarModelCommand(id), cancellationToken);
    }
}