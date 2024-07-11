using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.RentService.VehicleClientHistoryCommands.UpdateVehicleClientHistory;

public sealed record UpdateVehicleClientHistoryCommand(VehicleClientHistoryModel UpdatedModel) : IRequest<VehicleClientHistoryModel>;