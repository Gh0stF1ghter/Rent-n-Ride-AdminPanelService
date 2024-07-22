using AdminPanel.BLL.Models;
using CatalogGrpcService;
using Mapster;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Queries.CarModelQueries.GetCarModelsInRange;

public sealed class GetCarModelsInRangeHandler(CatalogService.CatalogServiceClient client) : IRequestHandler<GetCarModelsInRangeQuery, IEnumerable<CarModel>>
{
    public async Task<IEnumerable<CarModel>> Handle(GetCarModelsInRangeQuery query, CancellationToken cancellationToken)
    {
        var request = new GetModelListRequest
        {
            PageNumber = query.Page,
            PageSize = query.PageSize,
        };

        var response = await client.GetCarModelsAsync(request, cancellationToken: cancellationToken);

        var carModels = response.CarModels.Adapt<IEnumerable<CarModel>>();

        return carModels;
    }
}