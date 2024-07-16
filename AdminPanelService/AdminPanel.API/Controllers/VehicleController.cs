using AdminPanel.BLL.CQS.CatalogueService.Commands.VehicleCommands.AddVehicle;
using AdminPanel.BLL.CQS.CatalogueService.Commands.VehicleCommands.DeleteVehicle;
using AdminPanel.BLL.CQS.CatalogueService.Commands.VehicleCommands.UpdateVehicle;
using AdminPanel.BLL.CQS.CatalogueService.Queries.VehicleQueries.GetVehicleById;
using AdminPanel.BLL.CQS.CatalogueService.Queries.VehicleQueries.GetVehiclesInRange;

namespace AdminPanel.API.Controllers;

[ApiController]
[Route("api/vehicle")]
public class VehicleController(ISender sender) : ControllerBase
{
    [HttpGet]
    [ActionName("GetAllVehiclesInRange")]
    public async Task<IEnumerable<VehicleViewModel>> GetAll([FromQuery] int page = 1, [FromQuery] int pageSize = 10, CancellationToken cancellationToken = default)
    {
        var vehicles = await sender.Send(new GetVehiclesInRangeQuery(page, pageSize), cancellationToken);

        var vehiclesVMs = vehicles.Adapt<IEnumerable<VehicleViewModel>>();

        return vehiclesVMs;
    }

    [HttpGet("{id}")]
    [ActionName("GetVehicleById")]
    public async Task<VehicleViewModel> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var vehicle = await sender.Send(new GetVehicleByIdQuery(id), cancellationToken);

        var vehicleVM = vehicle.Adapt<VehicleViewModel>();

        return vehicleVM;
    }

    [HttpPost]
    [ActionName("CreateVehicle")]
    public async Task Create([FromBody] ShortVehicleViewModel createClientViewModel, CancellationToken cancellationToken)
    {
        var createVehicleModel = createClientViewModel.Adapt<VehicleModel>();

        await sender.Send(new AddVehicleCommand(createVehicleModel), cancellationToken);
    }

    [HttpPut("{id}")]
    [ActionName("UpdateVehicleById")]
    public async Task Update([FromRoute] Guid id, [FromBody] ShortVehicleViewModel updateVehicleViewModel, CancellationToken cancellationToken)
    {
        var vehicleModel = updateVehicleViewModel.Adapt<VehicleModel>();
        vehicleModel.Id = id;

        await sender.Send(new UpdateVehicleCommand(vehicleModel), cancellationToken);
    }

    [HttpDelete("{id}")]
    [ActionName("DeleteVehicleById")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await sender.Send(new DeleteVehicleCommand(id), cancellationToken);
    }
}