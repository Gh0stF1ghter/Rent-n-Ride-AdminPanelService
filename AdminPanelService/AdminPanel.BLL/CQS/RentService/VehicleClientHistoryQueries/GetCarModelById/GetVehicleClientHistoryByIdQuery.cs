using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.RentService.VehicleClientHistoryQueries.GetCarModelById;

public sealed record GetVehicleClientHistoryByIdQuery(Guid Id) : IRequest<VehicleClientHistoryModel>;