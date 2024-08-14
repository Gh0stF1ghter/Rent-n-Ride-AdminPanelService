using AdminPanel.API.ViewModels.UpdateViewModels;
using AdminPanel.BLL.CQS.CatalogueService.Queries.CarModelQueries.GetCarModelById;
using AdminPanel.BLL.CQS.UserService.ClientCommands.AddClient;
using AdminPanel.BLL.CQS.UserService.ClientCommands.DeleteClient;
using AdminPanel.BLL.CQS.UserService.ClientCommands.UpdateClient;
using AdminPanel.BLL.CQS.UserService.ClientQueries.GetVehicleById;
using AdminPanel.BLL.CQS.UserService.ClientQueries.GetVehiclesInRange;
using Microsoft.AspNetCore.Authorization;

namespace AdminPanel.API.Controllers;

[ApiController]
[Route("api/client")]
public class ClientController(ISender sender) : ControllerBase
{
    [HttpGet]
    [ActionName("GetAllClientsInRange")]
    public async Task<IEnumerable<ClientViewModel>> GetAll([FromQuery] int page = 1, [FromQuery] int pageSize = 10, CancellationToken cancellationToken = default)
    {
        var clients = await sender.Send(new GetClientsInRangeQuery(page, pageSize), cancellationToken);

        var clientsVMs = clients.Adapt<IEnumerable<ClientViewModel>>();

        return clientsVMs;
    }

    [HttpGet("{id}")]
    [ActionName("GetClientById")]
    public async Task<ClientViewModel> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var client = await sender.Send(new GetClientByIdQuery(id), cancellationToken);

        var clientVM = client.Adapt<ClientViewModel>();

        return clientVM;
    }

    [HttpPost]
    [ActionName("CreateClient")]
    public async Task Create([FromBody] ShortClientViewModel createClientViewModel, CancellationToken cancellationToken)
    {
        var createClientModel = createClientViewModel.Adapt<ClientModel>();

        await sender.Send(new AddClientCommand(createClientModel), cancellationToken);
    }

    [HttpPut("{id}")]
    [ActionName("UpdateClientById")]
    public async Task Update([FromRoute] Guid id, [FromBody] UpdateClientViewModel updateClientViewModel, CancellationToken cancellationToken)
    {
        var clientModel = updateClientViewModel.Adapt<ClientModel>();

        clientModel.Id = id;

        await sender.Send(new UpdateClientCommand(clientModel), cancellationToken);
    }

    [HttpDelete("{id}")]
    [ActionName("DeleteClientById")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await sender.Send(new DeleteClientCommand(id), cancellationToken);
    }
}