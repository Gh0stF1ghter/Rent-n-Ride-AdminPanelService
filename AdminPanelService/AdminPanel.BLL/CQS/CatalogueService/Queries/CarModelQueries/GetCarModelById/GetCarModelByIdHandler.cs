using AdminPanel.BLL.Models;
using CatalogGrpcService;
using Mapster;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Queries.CarModelQueries.GetCarModelById;

public sealed class GetCarModelByIdHandler(CatalogService.CatalogServiceClient client) : IRequestHandler<GetCarModelByIdQuery, CarModel>
{
    public async Task<CarModel> Handle(GetCarModelByIdQuery query, CancellationToken cancellationToken)
    {
        var carModelRequest = new GetModelRequest
        {
            Id = query.Id.ToString()
        };

        var carModelResponse = await client.GetCarModelAsync(carModelRequest, cancellationToken: cancellationToken);

        var carModel = carModelResponse.CarModel.Adapt<CarModel>();

        return carModel;
    }
}