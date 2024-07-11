using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Queries.CarModelQueries.GetCarModelsInRange;

public sealed class GetCarModelsInRangeHandler : IRequestHandler<GetCarModelsInRangeQuery, IEnumerable<CarModel>>
{
    public async Task<IEnumerable<CarModel>> Handle(GetCarModelsInRangeQuery query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}