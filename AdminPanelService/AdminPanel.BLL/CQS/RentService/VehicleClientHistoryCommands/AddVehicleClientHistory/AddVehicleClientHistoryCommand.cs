using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.RentService.VehicleClientHistoryCommands.AddVehicleClientHistory;

public sealed record AddVehicleClientHistoryCommand(VehicleClientHistoryModel NewModel) : IRequest;