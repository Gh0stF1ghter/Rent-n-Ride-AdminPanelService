using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Queries.ManufacturerQueries.GetManufacturersInRange;

public record GetManufacturersInRangeQuery(int Page, int PageSize) : IRequest<IEnumerable<ManufacturerModel>>;