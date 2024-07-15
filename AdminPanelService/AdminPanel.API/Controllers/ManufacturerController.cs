using AdminPanel.BLL.CQS.CatalogueService.Commands.ManufacturerCommands.AddManufacturer;
using AdminPanel.BLL.CQS.CatalogueService.Commands.ManufacturerCommands.DeleteManufacturer;
using AdminPanel.BLL.CQS.CatalogueService.Commands.ManufacturerCommands.UpdateManufacturer;
using AdminPanel.BLL.CQS.CatalogueService.Queries.ManufacturerQueries.GetManufacturerById;
using AdminPanel.BLL.CQS.CatalogueService.Queries.ManufacturerQueries.GetManufacturersInRange;

namespace AdminPanel.API.Controllers;

[ApiController]
[Route("api/manufacturer")]
public class ManufacturerController(ISender sender) : ControllerBase
{
    [HttpGet]
    [ActionName("GetAllManufacturersInRange")]
    public async Task<IEnumerable<ManufacturerViewModel>> GetAll([FromQuery] int page, [FromQuery] int pageSize, CancellationToken cancellationToken)
    {
        var manufacturers = await sender.Send(new GetManufacturersInRangeQuery(page, pageSize), cancellationToken);

        var manufacturersVMs = manufacturers.Adapt<IEnumerable<ManufacturerViewModel>>();

        return manufacturersVMs;
    }

    [HttpGet("{id}")]
    [ActionName("GetManufacturerById")]
    public async Task<ManufacturerViewModel> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var manufacturer = await sender.Send(new GetManufacturerByIdQuery(id), cancellationToken);

        var manufacturerVM = manufacturer.Adapt<ManufacturerViewModel>();

        return manufacturerVM;
    }

    [HttpPost]
    [ActionName("CreateManufacturer")]
    public async Task<ManufacturerViewModel> Create([FromBody] ShortManufacturerViewModel createManufacturerViewModel, CancellationToken cancellationToken)
    {
        var manufacturerModel = createManufacturerViewModel.Adapt<ManufacturerModel>();

        var newManufacturer = await sender.Send(new AddManufacturerCommand(manufacturerModel), cancellationToken);

        var manufacturerVM = newManufacturer.Adapt<ManufacturerViewModel>();

        return manufacturerVM;
    }

    [HttpPut("{id}")]
    [ActionName("UpdateManufacturerById")]
    public async Task<ManufacturerViewModel> Update([FromRoute] Guid id, [FromBody] ShortManufacturerViewModel updateManufacturerViewModel, CancellationToken cancellationToken)
    {
        var manufacturerModel = updateManufacturerViewModel.Adapt<ManufacturerModel>();
        manufacturerModel.Id = id;

        var newManufacturer = await sender.Send(new UpdateManufacturerCommand(manufacturerModel), cancellationToken);

        var manufacturerVM = newManufacturer.Adapt<ManufacturerViewModel>();

        return manufacturerVM;
    }

    [HttpDelete("{id}")]
    [ActionName("DeleteManufacturerById")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await sender.Send(new DeleteManufacturerCommand(id), cancellationToken);
    }
}