using AdminPanel.BLL.Models;
using CatalogGrpcService;
using Mapster;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Queries.CarModelQueries.GetCarModelById;

public sealed class GetCarModelByIdHandler(CatalogService.CatalogServiceClient client) : IRequestHandler<GetCarModelByIdQuery, CarModel>
{
    public async Task<CarModel> Handle(GetCarModelByIdQuery query, CancellationToken cancellationToken)
    {
        var request = new GetModelRequest
        {
            Id = query.Id.ToString()
        };

        var response = await client.GetCarModelAsync(request, cancellationToken: cancellationToken);

        var carModel = response.CarModel.Adapt<CarModel>();

        return carModel;
    }
}