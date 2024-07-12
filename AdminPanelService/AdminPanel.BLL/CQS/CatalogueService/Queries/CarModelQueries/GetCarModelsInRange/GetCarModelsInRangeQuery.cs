using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Queries.CarModelQueries.GetCarModelsInRange;

public sealed record GetCarModelsInRangeQuery(int Page, int PageSize) : IRequest<IEnumerable<CarModel>>;