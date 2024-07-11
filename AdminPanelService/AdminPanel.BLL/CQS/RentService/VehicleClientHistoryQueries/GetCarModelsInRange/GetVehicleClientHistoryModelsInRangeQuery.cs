using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.RentService.CarModelQueries.GetCarModelsInRange;

public sealed record GetVehicleClientHistoryModelsInRangeQuery(int Page, int PageSize) : IRequest<IEnumerable<VehicleClientHistoryModel>>;