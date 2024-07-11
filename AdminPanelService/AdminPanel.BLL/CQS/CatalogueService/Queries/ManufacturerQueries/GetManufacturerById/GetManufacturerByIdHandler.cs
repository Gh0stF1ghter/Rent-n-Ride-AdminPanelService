using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Queries.ManufacturerQueries.GetManufacturerById;

public sealed class GetManufacturerByIdHandler : IRequestHandler<GetManufacturerByIdQuery, ManufacturerModel>
{
    public Task<ManufacturerModel> Handle(GetManufacturerByIdQuery query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}