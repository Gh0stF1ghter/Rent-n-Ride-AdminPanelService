using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Queries.CarModelQueries.GetCarModelById;

public sealed class GetCarModelByIdHandler : IRequestHandler<GetCarModelByIdQuery, CarModel>
{
    public Task<CarModel> Handle(GetCarModelByIdQuery query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}