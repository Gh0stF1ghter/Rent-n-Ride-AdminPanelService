using AdminPanel.BLL.CQS.RentService.VehicleClientHistoryCommands.AddVehicleClientHistory;
using AdminPanel.BLL.CQS.RentService.VehicleClientHistoryCommands.DeleteVehicleClientHistory;
using AdminPanel.BLL.CQS.RentService.VehicleClientHistoryCommands.UpdateVehicleClientHistory;
using AdminPanel.BLL.CQS.RentService.VehicleClientHistoryQueries.GetCarModelById;
using AdminPanel.BLL.CQS.RentService.VehicleClientHistoryQueries.GetCarModelsInRange;
using Microsoft.AspNetCore.Authorization;

namespace AdminPanel.API.Controllers;

[ApiController]
[Authorize("use:dashboard")]
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
    public async Task<VehicleClientHistoryViewModel> Create([FromBody] ShortVehicleClientHistoryViewModel createVehicleClientHistoryViewModel, CancellationToken cancellationToken)
    {
        var vehicleClientHistoryModel = createVehicleClientHistoryViewModel.Adapt<VehicleClientHistoryModel>();

        var newVehicleClientHistory = await sender.Send(new AddVehicleClientHistoryCommand(vehicleClientHistoryModel), cancellationToken);

        var vehicleClientHistoryVM = newVehicleClientHistory.Adapt<VehicleClientHistoryViewModel>();

        return vehicleClientHistoryVM;
    }

    [HttpPut("{id}", Name = "UpdateVehicleClientHistoryById")]
    public async Task<VehicleClientHistoryViewModel> Update([FromRoute] Guid id, [FromBody] ShortVehicleClientHistoryViewModel updateModelNameViewModel, CancellationToken cancellationToken)
    {
        var vehicleClientHistoryModel = updateModelNameViewModel.Adapt<VehicleClientHistoryModel>();

        vehicleClientHistoryModel.Id = id;

        var newVehicleClientHistory = await sender.Send(new UpdateVehicleClientHistoryCommand(vehicleClientHistoryModel), cancellationToken);

        var vehicleClientHistoryVM = newVehicleClientHistory.Adapt<VehicleClientHistoryViewModel>();

        return vehicleClientHistoryVM;
    }

    [HttpDelete("{id}", Name = "DeleteVehicleClientHistoryById")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await sender.Send(new DeleteVehicleClientHistoryCommand(id), cancellationToken);
    }
}