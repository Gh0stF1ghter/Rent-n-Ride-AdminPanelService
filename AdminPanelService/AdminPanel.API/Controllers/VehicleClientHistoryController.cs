using AdminPanel.BLL.CQS.RentService.VehicleClientHistoryCommands.AddVehicleClientHistory;
using AdminPanel.BLL.CQS.RentService.VehicleClientHistoryCommands.DeleteVehicleClientHistory;
using AdminPanel.BLL.CQS.RentService.VehicleClientHistoryCommands.UpdateVehicleClientHistory;
using AdminPanel.BLL.CQS.RentService.VehicleClientHistoryQueries.GetCarModelById;
using AdminPanel.BLL.CQS.RentService.VehicleClientHistoryQueries.GetCarModelsInRange;

namespace AdminPanel.API.Controllers;

[ApiController]
[Route("api/history-of-use")]
public class VehicleClientHistoryController(ISender sender) : ControllerBase
{
    [HttpGet(Name = "GetAllVehicleClientHistoriesInRange")]
    public async Task<IEnumerable<VehicleClientHistoryViewModel>> GetAll([FromQuery] int page = 1, [FromQuery] int pageSize = 10, CancellationToken cancellationToken = default)
    {
        var vehicleClientHistories = await sender.Send(new GetVehicleClientHistoriesInRangeQuery(page, pageSize), cancellationToken);

        var vehicleClientHistoriesVMs = vehicleClientHistories.Adapt<IEnumerable<VehicleClientHistoryViewModel>>();

        return vehicleClientHistoriesVMs;
    }

    [HttpGet("{id}", Name = "GetVehicleClientHistoryById")]
    public async Task<VehicleClientHistoryViewModel> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var vehicleClientHistory = await sender.Send(new GetVehicleClientHistoryByIdQuery(id), cancellationToken);

        var vehicleClientHistoryVM = vehicleClientHistory.Adapt<VehicleClientHistoryViewModel>();

        return vehicleClientHistoryVM;
    }

    [HttpPost(Name = "CreateVehicleClientHistory")]
    public async Task Create([FromBody] ShortVehicleClientHistoryViewModel createVehicleClientHistoryViewModel, CancellationToken cancellationToken)
    {
        var vehicleClientHistoryModel = createVehicleClientHistoryViewModel.Adapt<VehicleClientHistoryModel>();
        
        await sender.Send(new AddVehicleClientHistoryCommand(vehicleClientHistoryModel), cancellationToken);
    }

    [HttpPut("{id}", Name = "UpdateVehicleClientHistoryById")]
    public async Task Update([FromRoute] Guid id, [FromBody] ShortVehicleClientHistoryViewModel updateModelNameViewModel, CancellationToken cancellationToken)
    {
        var vehicleClientHistoryModel = updateModelNameViewModel.Adapt<VehicleClientHistoryModel>();

        vehicleClientHistoryModel.Id = id;

        await sender.Send(new UpdateVehicleClientHistoryCommand(vehicleClientHistoryModel), cancellationToken);
    }

    [HttpDelete("{id}", Name = "DeleteVehicleClientHistoryById")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await sender.Send(new DeleteVehicleClientHistoryCommand(id), cancellationToken);
    }
}