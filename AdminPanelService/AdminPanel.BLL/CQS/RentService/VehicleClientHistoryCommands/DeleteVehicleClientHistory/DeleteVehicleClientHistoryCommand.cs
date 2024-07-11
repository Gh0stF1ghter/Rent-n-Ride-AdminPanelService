using MediatR;

namespace AdminPanel.BLL.CQS.RentService.VehicleClientHistoryCommands.DeleteVehicleClientHistory;

public sealed record DeleteVehicleClientHistoryCommand(Guid Id) : IRequest;