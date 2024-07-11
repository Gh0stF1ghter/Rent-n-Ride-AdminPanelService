using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.RentService.VehicleClientHistoryQueries.GetCarModelsInRange;

public sealed record GetVehicleClientHistoriesInRangeQuery(int Page, int PageSize) : IRequest<IEnumerable<VehicleClientHistoryModel>>;