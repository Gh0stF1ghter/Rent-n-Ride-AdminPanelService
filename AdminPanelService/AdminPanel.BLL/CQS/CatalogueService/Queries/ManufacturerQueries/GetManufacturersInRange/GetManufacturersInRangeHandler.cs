using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Queries.ManufacturerQueries.GetManufacturersInRange;

public sealed class GetManufacturersInRangeHandler : IRequestHandler<GetManufacturersInRangeQuery, IEnumerable<ManufacturerModel>>
{
    public async Task<IEnumerable<ManufacturerModel>> Handle(GetManufacturersInRangeQuery query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}