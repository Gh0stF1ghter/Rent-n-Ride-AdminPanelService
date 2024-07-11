using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.RentService.CarModelQueries.GetCarModelById;

public sealed record GetVehicleClientHistoryByIdQuery(Guid Id) : IRequest<VehicleClientHistoryModel>;